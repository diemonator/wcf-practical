using System;
using System.ServiceModel;

namespace Service
{
    interface IMyEvent
    {
        [OperationContract(IsOneWay = true)]
        void OnOrder(int orderId, string productId, DateTime moment);
    }
}