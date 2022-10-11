using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    public class SingleCastDelegate
    {
        public delegate void delMethod();

        public class P
        {
            public static void display()
            {
                Console.WriteLine("Hello!");
            }

            public static void show()
            {
                Console.WriteLine("Hi!");
            }
            public void print()
            {
                Console.WriteLine("Print!");
            }
        }

        static void printSingleCastDelegate()
        {
            delMethod del1 = P.show;
            delMethod del2 = new delMethod(P.display);
            P obj = new P();

            delMethod del3 = obj.print;
        }
    }
}
