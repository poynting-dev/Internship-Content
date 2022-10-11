using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class demo
    {
        public static void one(int a)
        {
            Console.WriteLine("Addition={0}", a + 10);
        }
        public static void two(int a)
        {
            Console.WriteLine("Multiple={0}", a * a);
        }
    }


    class demoClass
    {
        delegate void delegateEx(int x);

        public static void Test()
        {
            delegateEx dg = new delegateEx(Operation.Add);
            dg += Operation.Square;

            Delegate[] del = dg.GetInvocationList();
            foreach (delegateEx d in del)
            {
                try
                {
                    d(10);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Exception occured: " + ex);
                }
            }

            //dg(2);
            //dg(5);
            Console.Read();
        }
    }
}