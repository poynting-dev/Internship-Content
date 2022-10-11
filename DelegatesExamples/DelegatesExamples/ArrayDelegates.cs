using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Calculator
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition: " + (a + b));
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine("Multiply: " + (a * b));
        }
    }

    delegate void delCalc(int a, int b);
    public class Calc
    {
        public static void printCalc()
        {
            delCalc[] dc =
            {
                new delCalc(Calculator.Add),
                new delCalc(Calculator.Multiply),
            };
            foreach (delCalc d in dc)
            {
                d(5, 10);
                d(15, 20);
            }
        }
    }

}
