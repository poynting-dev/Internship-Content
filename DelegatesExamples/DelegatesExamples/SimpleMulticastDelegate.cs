using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Operation
    {
        public static void Add(int a)
        {
            Console.WriteLine("Addition={0}", a + 10);
            throw new Exception("Error");
        }
        public static void Square(int a)
        {
            Console.WriteLine("Multiple={0}", a * a);
        }
    }

    class SimpleMulticastDelegate
    {
        delegate void delegateEx(int x);

        public static void simpleDelegate()
        {
            delegateEx dg = new delegateEx(Operation.Add);
            dg += Operation.Square;

            dg(2);
            dg(5);
            ////Console.Read();
        }
    }
}