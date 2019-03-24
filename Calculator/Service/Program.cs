using CalculatorContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            // setup service
            ServiceHost host = new ServiceHost(typeof(Calculator));
            Type contract = typeof(ICalculator);
            WSHttpBinding binding = new WSHttpBinding();
            Uri address = new Uri("http://localhost:8000/calculatorService");
            host.AddServiceEndpoint(contract, binding, address);
            // start hosting
            host.Open();
            Console.WriteLine("The service is being hosted at address " + address);
            Console.WriteLine("Press <ENTER> to stop hosting.\n");
            Console.ReadLine();
            // stop hosting
            host.Close();
        }
    }
}
