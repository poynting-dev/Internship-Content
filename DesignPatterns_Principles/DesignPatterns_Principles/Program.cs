using System.Data;
using System.Data.Common;
using System.Collections;
using static Demo.LiskovSubstitionPrinciple;

namespace Demo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Test t  = new Test();
            t.run();

            //interfaceSegregation
            //InterfaceSegregation ifs = new InterfaceSegregation();
            //ifs.print();

            //Single Responsibilty
            //singleResponsibilty s = new singleResponsibilty();
            //s.print();

            //LiskovSubstitionPrinciple
            //print();
            //RegularSavingAccount r = new RegularSavingAccount();
            //r.Balance = 5000;
            //Console.WriteLine(r.CalcInterest());
        }
    }
}