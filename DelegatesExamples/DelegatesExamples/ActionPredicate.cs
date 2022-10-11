using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class actionPredicate
    {
        public static void printPredicate()
        {
            Action<string> MyAction = y => Console.Write(y);
            MyAction("Hello");
        }
    }
}
