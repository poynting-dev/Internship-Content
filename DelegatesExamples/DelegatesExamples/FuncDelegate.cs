using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Interest
    {
        public int P { get; set; }
        public int R { get; set; }
        public int T { get; set; }
    }

    public class calcInterest
    {
        delegate void CalcInterestDelegate(double x, double y, double z);
        public static void printInterest()
        {
            double SI;
            Interest obj = new Interest();
            obj.P = 120 ; obj.R = 4; obj.T = 2;
            Func<Interest, double> calcSI = SIObj => (SIObj.P * SIObj.R* SIObj.T)/100;
            SI = calcSI(obj);

            Console.WriteLine("Calculated Simple Interest is: " + SI);
        }
    }
}
