using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorContract;
using System.ServiceModel.Channels;

namespace Calculator
{
    class CalculatorClientProxy : ClientBase<ICalculator>
    {
        public ICalculator CalculatorService { get { return Channel; } }

        public CalculatorClientProxy(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress) { }

    }
}
