using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class Calculator : ICalculator
    {
        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine("Numer {0} has been added to {1} and the resut is {2}", num1, num2, result);
            return result;
        }

        public double Divide(double num1, double num2)
        {
            if (num1 == 0 || num2 == 0) throw new DivideByZeroException("Can't devide by zero try other numbers");
            double result = num1 / num2;
            Console.WriteLine("Numer {0} has been divided to {1} and the resut is {2}", num1, num2, result);
            return result;
        }

        public double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            Console.WriteLine("Numer {0} has been multiplied to {1} and the resut is {2}", num1, num2, result);
            return result;
        }

        public double Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            Console.WriteLine("Numer {0} has been subtracted to {1} and the resut is {2}", num1, num2, result);
            return result;
        }
    }
}
