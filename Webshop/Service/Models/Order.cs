using System;
using System.Runtime.Serialization;

namespace Service.Models
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int OrderId { get; set; }
        [DataMember]
        public string ProductId { get; set; }
        [DataMember]
        public DateTime Moment { get; set; }
        public IWebshopCallback WebshopCallback { get; set; }

        public Order(int orderId, string productId, DateTime moment, IWebshopCallback callback)
        {
            OrderId = orderId;
            ProductId = productId;
            Moment = moment;
            WebshopCallback = callback;
        }
    }
}