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
using Webshop.ServiceReference;
using System.Threading;

namespace Webshop
{
    public partial class WebshopForm : Form, IWebshopCallback
    {
        private WebshopClient proxy;

        public WebshopForm()
        {
            InitializeComponent();
            proxy = new WebshopClient(new InstanceContext(this));
            if (proxy != null)
            { 
                PopulateLists(proxy.GetProductList());
                proxy.Connect();
            }
        }

        private void BtnShopName_Click(object sender, EventArgs e)
        {
            lStoreName.Text = proxy.GetWebshopName();
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            PopulateLists(proxy.GetProductList());
        }

        private void BtnProductInfo_Click(object sender, EventArgs e)
        {
            if (lbId.SelectedItem != null) MessageBox.Show(proxy.GetProductInfo(lbId.SelectedItem.ToString()), "Product Information");
            else MessageBox.Show("Please select an item", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            int index = lbId.SelectedIndex;
            if (index > -1 && proxy.BuyProduct(lbId.SelectedItem.ToString()))
            {
                int result = Convert.ToInt32(lbStock.Items[index].ToString());
                lbStock.Items[index] = --result;
            }
            else MessageBox.Show("The selected product can not be bought", "Failed");
        }

        private void LbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ListBox)sender).SelectedIndex;
            lbId.SelectedIndex = index;
            lbPrice.SelectedIndex = index;
            lbStock.SelectedIndex = index;
        }

        private void UpdateLabel(int numberOfConnectedClients)
        {
            lConnect.Text = "The number of connected clients is: " + numberOfConnectedClients;
        }

        private void UpdateProduct(Item product)
        {
            if (lbId.Items != null && lbId.Items.Contains(product.ProductId)) lbStock.Items[lbId.Items.IndexOf(product.ProductId)] = product.Stock;
        }

        private void ClearListBoxes()
        {
            lbId.Items.Clear();
            lbPrice.Items.Clear();
            lbStock.Items.Clear();
        }

        // This is required to prevent deadlock
        // Deadlock is seen when new client joins while data is shown on listbox
        public void NewClientConnected(int numberOfConnectedClients)
        {
            UpdateLabel(numberOfConnectedClients);
        }

        // This is required to prevent deadlock
        public void ProductSold(Item product)
        {
            UpdateProduct(product);
        }

        public void DisconnectedClient(int numberOfConnectedClients)
        {
            UpdateLabel(numberOfConnectedClients);
        }

        private void WebshopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            proxy.Disconnect();
        }

        private void PopulateLists(List<Item> items)
        {
            ClearListBoxes();
            foreach (Item item in items)
            {
                lbId.Items.Add(item.ProductId);
                lbPrice.Items.Add(item.Price);
                lbStock.Items.Add(item.Stock);
            }
        }
    }
}
