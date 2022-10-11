using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class AnonymousDelegate
    {
        delegate void operation();
        public static void anonymousTest()
        {
            operation ob = delegate
            {
                Console.WriteLine("This is an anonymous delegate function.");
            };
            ob();
            Console.Read();
        }
    }
}
