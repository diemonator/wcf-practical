using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    [ServiceContract(CallbackContract = typeof(IMyEvent))]
    interface IShipping
    {
        [OperationContract]
        List<Order> GetOrderList();
        [OperationContract]
        bool ShipOrder(int OrderId);
        [OperationContract]
        void Subscribe();
        [OperationContract]
        void UnSubscribe();
    }
}
