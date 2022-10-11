using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable_EquitableInterfaces
{
    public class IComparable_IEquatable
    {
        public class Car : IComparable
        {
            public string Name
            {
                get;
                set;
            }
            public int CompareTo(object obj)
            {
                if (!(obj is Car))
                {
                    throw new ArgumentException("Compared Object is not of car");
                }
                Car car = obj as Car;
                return Name.CompareTo(car.Name);
            }
        }

        private static void showCmparable(string[] args)
        {
            Car[] cars = new Car[]
            {
                new Car()
                {
                    Name = "Zinco"
                }, 
                new Car()
                {
                    Name = "VW"
                }, 
                new Car()
                {
                    Name = "BMW"
                }
            };
            Array.Sort(cars);
            foreach(Car car in cars)
                Console.WriteLine(car.Name);
        }
    }
}
