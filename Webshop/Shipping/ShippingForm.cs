﻿using Shipping.ServiceReference;
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

namespace Shipping
{
    public partial class ShippingForm : Form, IShippingCallback
    {
        private ShippingClient proxy;

        public ShippingForm()
        {
            InitializeComponent();
            proxy = new ShippingClient(new InstanceContext(this));
            if (proxy != null)
            { 
                proxy.Subscribe();
                ShowOrders(proxy.GetOrderList());
            }
        }

        public void OnOrder(int orderId, string productId, DateTime moment)
        {
            lbOrderId.Items.Add(orderId);
            lbDateTime.Items.Add(productId + " - " + moment);
        }

        private void BtnShowOrder_Click(object sender, EventArgs e)
        {
            ShowOrders(proxy.GetOrderList());
        }

        private void ShowOrders(List<Order> orders)
        {
            ClearListBoxes();
            foreach (var item in orders)
            {
                lbOrderId.Items.Add(item.OrderId);
                lbDateTime.Items.Add(item.ProductId + " - " + item.Moment);
            }
        }

        private void ClearListBoxes()
        {
            lbOrderId.Items.Clear();
            lbDateTime.Items.Clear();
        }

        private void ShippingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            proxy.UnSubscribe();
        }
    }
}
