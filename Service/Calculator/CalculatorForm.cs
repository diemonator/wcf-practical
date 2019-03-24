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
using Calculator.ServiceReference;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private CalculatorClient proxy;

        public CalculatorForm()
        {
            InitializeComponent();
            proxy = new CalculatorClient();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues(out double number1, out double number2);
                double answer = proxy.Add(number1, number2);
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
                double answer = proxy.Subtract(number1, number2);
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
                double answer = proxy.Multiply(number1, number2);
                tbResult.Text = answer.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            GetValues(out double number1, out double number2);
            try
            {
                double answer = proxy.Divide(number1, number2);
                tbResult.Text = answer.ToString();
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void TbNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput((TextBox)sender, e);
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
