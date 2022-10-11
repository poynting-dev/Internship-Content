using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable_EquitableInterfaces.IComparable_interface_Example
{
    public class SortUsingIComparble
    {
        public static void SortUsingIComparbleExample()
        {
            List<SmartPhone> smartPhones = new List<SmartPhone>()
            {
                new SmartPhone()
                {
                    Name =  "OnePlus",
                    IsFlagship = true,
                    OS = "Android",
                    Price = 37999
                },
                new SmartPhone()
                {
                    Name = "Iphone 13 plus",
                    IsFlagship = true,
                    OS = "iOS",
                    Price = 120999
                },
                new SmartPhone()
                {
                    Name = "Samsung Note 10",
                    IsFlagship = true,
                    OS = "Android 10",
                    Price = 110000
                },
                new SmartPhone()
                {
                    Name = "Samsung S20 Ultra",
                    IsFlagship = true,
                    OS = "Android 10",
                    Price = 130000
                },
                new SmartPhone()
                {
                    Name = "IPhone 11 Pro",
                    IsFlagship = true,
                    OS = "IOS 11",
                    Price = 130000
                }
            };
            smartPhones.Sort();
            foreach(var e in smartPhones)
                Console.WriteLine(e.ToString());

        }
    }
}
