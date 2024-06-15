using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    internal class CalculatorClass
    {
        public delegate double Formula <T> (double num1, double num2);


        public double GetSum(double a, double b)
        {
            return a + b;
        }
        public double GetDifference(double a, double b)
        {
            return a - b;
        }

        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public double GetQuotient(double a, double b)
        {
            return a / b;
        }



        public event Formula<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the delegate");
            }
            remove
            {
                Console.WriteLine("Removed the Delegate");
            }
        }
       
    }//end tag
}
