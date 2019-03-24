using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CalculatorContract
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double num1, double num2);
        [OperationContract]
        double Subtract(double num1, double num2);
        [OperationContract]
        double Multiply(double num1, double num2);
        [OperationContract]
        double Divide(double num1, double num2);
    }
}
