using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IWebshopCallback
    {
        [OperationContract(IsOneWay = true)]
        void NewClientConnected(int numberOfConnectedClients);

        [OperationContract(IsOneWay = true)]
        void ProductSold(Item product);

        [OperationContract(IsOneWay = true)]
        void DisconnectedClient(int numberOfConnectedClients);
    }
}
