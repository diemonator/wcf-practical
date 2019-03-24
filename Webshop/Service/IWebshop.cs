using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Service.Models;

namespace Service
{
    [ServiceContract(CallbackContract = typeof(IWebshopCallback))]
    interface IWebshop
    {
        [OperationContract]
        string GetWebshopName();
        [OperationContract]
        Item[] GetProductList();
        [OperationContract]
        string GetProductInfo(string productId);
        [OperationContract]
        bool BuyProduct(string productId);
        [OperationContract(IsOneWay = true)]
        void Connect();
    }
}
