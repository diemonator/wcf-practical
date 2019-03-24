using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup is in XML
            ServiceHost host = new ServiceHost(typeof(Calculator));
            // Opening service
            host.Open();
            Console.WriteLine("The service is being hosted");
            Console.WriteLine("Press <ENTER> to stop hosting.\n");
            Console.ReadLine();
            //Closing service
            host.Close();
        }
    }
}
