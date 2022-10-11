using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Interest
    {
        double p { get; set; }
        double r { get; set; }
        double t { get; set; }
    }

    class Program
    {
        //delegate void delegateEx(int x);

        public static void Main(String[] args)
        {
            Interest obj = new Interest();
            obj.P = 120;
            obj.R = 1;
            obj.T = (int)3.25;
            Func<Interest, double> calcSI = SIobj => (SIobj.P * SIobj.R * SIobj.T) / 100;
            double SI = calcSI(obj);
            Console.WriteLine(SI);

            //primeCheck.printPrimes();
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            //List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);
            Console.Read();
        }
    }
}

//class Program
//{
//    // Declare a delegate
//    delegate double CalculateSimpleInterest(double para1, double para2, double para3);
//    static CalculateSimpleInterest dObjSI = getTotalInterest;

//    static void Main(string[] args)
//    {
//        double SI;
//        //Calculating simple interest
//        SI = dObjSI.Invoke(120, 1, 3.25);
//        Console.WriteLine(SI);

//        //using multicast delegate by invoking method getInterestRatePerYear()
//        dObjSI += new CalculateSimpleInterest(getInterestRatePerYear);
//        double Rate = dObjSI.Invoke(SI, 120, 1);
//        Console.WriteLine("APR rate is {0}", Rate);

//        //using multicast delegate by invoking method getInterestTimeSpan()
//        dObjSI += new CalculateSimpleInterest(getInterestTimeSpan);
//        double TimeSpan = dObjSI.Invoke(SI, 120, 3.25);
//        Console.WriteLine("Time Span is {0}", TimeSpan);


//        Console.ReadKey();
//    }

//    static double getTotalInterest(double p, double t, double r)
//    {
//        return (p * t * r) / 100;
//    }
//    static double getInterestRatePerYear(double SI, double p, double t)
//    {
//        return (SI * 100) / (p * t);
//    }
//    static double getInterestTimeSpan(double SI, double p, double r)
//    {
//        return (SI * 100) / (p * r);
//    }
//}
