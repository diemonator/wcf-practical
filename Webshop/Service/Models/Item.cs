using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    [DataContract]
    public class Item
    {
        private int stock;
        [DataMember]
        public string ProductId { get; set; }
        public string ProductInfo { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public int Stock
        {
            get { return stock; }
            set
            {
                if (value >= 0)
                {
                    stock = value;
                    if (value > 0)
                        OnSale = true;
                    else
                        OnSale = false;
                }
                else
                {
                    value = 0;
                    OnSale = false;
                }
            }
        }
        public bool OnSale { get; set; }

        public Item(string prodId, string prodInfo, double price, int stock)
        {
            ProductId = prodId;
            ProductInfo = prodInfo;
            Price = price;
            Stock = stock;
        }
    }
}
