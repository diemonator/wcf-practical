using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorContract;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private CalculatorClientProxy proxy;

        public CalculatorForm()
        {
            InitializeComponent();
            WSHttpBinding binding = new WSHttpBinding();
            Uri address = new Uri("http://localhost:8000/calculatorService");
            EndpointAddress endpointAddress = new EndpointAddress(address);
            proxy = new CalculatorClientProxy(binding, endpointAddress);
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues(out double number1, out double number2);
                double answer = proxy.CalculatorService.Add(number1, number2);
                tbResult.Text = answer.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues(out double number1, out double number2);
                double answer = proxy.CalculatorService.Subtract(number1, number2);
                tbResult.Text = answer.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues(out double number1, out double number2);
                double answer = proxy.CalculatorService.Multiply(number1, number2);
                tbResult.Text = answer.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues(out double number1, out double number2);
                double answer = proxy.CalculatorService.Divide(number1, number2);
                tbResult.Text = answer.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TbNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput((TextBox) sender, e);
        }

        private void TbNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(sender as TextBox, e);
        }

        private void GetValues(out double number1, out double number2)
        {
            if (!string.IsNullOrEmpty(tbNum1.Text) && !string.IsNullOrWhiteSpace(tbNum2.Text))
            {
                number1 = Convert.ToDouble(tbNum1.Text);
                number2 = Convert.ToDouble(tbNum2.Text);
                return;
            }
            throw new FormatException("Error Processing");
        }

        private void CheckInput(TextBox sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            // only allow one decimal point
            if ((e.KeyChar == '.') && sender.Text.IndexOf('.') > -1) e.Handled = true;
        }
    }
}
