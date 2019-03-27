using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Service.Models;

namespace Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class Webshop : IWebshop, IShipping
    {
        private List<Item> products;
        private List<IWebshopCallback> clients;
        private List<Order> orders;
        private Action<int, string, DateTime> myEvent;
        private static int counter = 1;

        public Webshop()
        {
            clients = new List<IWebshopCallback>();
            products = new List<Item>()
            {
                new Item("Dracula", "Scary", 10.5, 5),
                new Item("A room with a view", "Drama", 15, 9),
                new Item("Uncle Tom's Cabin", "Comedy", 12.5, 54)
            };
            orders = new List<Order>();
            myEvent = delegate { };
        }

        public void Connect()
        {
            IWebshopCallback currentClient = OperationContext.Current.GetCallbackChannel<IWebshopCallback>();
            if (!clients.Contains(currentClient))
            {
                clients.Add(currentClient);
                clients.ForEach(client => client.NewClientConnected(clients.Count));
            }
        }

        public bool BuyProduct(string productId)
        {
            IWebshopCallback currentClient = OperationContext.Current.GetCallbackChannel<IWebshopCallback>();
            Item item = GetProduct(productId);
            if (item.OnSale)
            {
                Order order = new Order(counter++, productId, DateTime.Now, currentClient);
                orders.Add(order);
                if (ShipOrder(order.OrderId))
                { 
                    item.Stock--;
                    foreach (IWebshopCallback client in clients)
                    {
                        if (client != currentClient) client.ProductSold(item);
                    }
                    return true;
                }
            }
            return false;
        }

        public string GetProductInfo(string productId)
        {
            return GetProduct(productId).ProductInfo;
        }

        public List<Item> GetProductList()
        {
            return products;
        }

        public string GetWebshopName()
        {
            return "Emil & Inc.";
        }

        private Item GetProduct(string productId)
        {
            try
            {
                return products.Find(item => item.ProductId == productId);
            }
            catch (ArgumentNullException)
            {
                return null;   
            }
        }

        public List<Order> GetOrderList()
        {
            return orders;
        }

        public bool ShipOrder(int OrderId)
        {
            try
            {
                Order order = orders.Find(o => o.OrderId == OrderId);
                myEvent(OrderId, order.ProductId, order.Moment);
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        public void UnSubscribe()
        {
            IMyEvent myEvent = OperationContext.Current.GetCallbackChannel<IMyEvent>();
            this.myEvent -= myEvent.OnOrder;
        }

        public void Subscribe()
        {
            IMyEvent myEvent = OperationContext.Current.GetCallbackChannel<IMyEvent>();
            this.myEvent += myEvent.OnOrder;
        }

        public void Disconnect()
        {
            IWebshopCallback currentClient = OperationContext.Current.GetCallbackChannel<IWebshopCallback>();
            if (clients.Contains(currentClient))
            {
                clients.Remove(currentClient);
                clients.ForEach(client => client.DisconnectedClient(clients.Count));
            }
        }
    }
}
