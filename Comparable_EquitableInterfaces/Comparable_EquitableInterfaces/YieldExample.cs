using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable_EquitableInterfaces
{
    public static class YieldExample
    {
        public static void YieldEx()
        {
            List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> cummulative = compute(lst);
            foreach (int i in cummulative)
                Console.Write(i + " ");
        }
        static IEnumerable<int> compute(List<int> lst)
        {
            int sum = 0;
            foreach (int i in lst)
            {
                sum += i;
                yield return sum;
            }   
        }
    }
}
