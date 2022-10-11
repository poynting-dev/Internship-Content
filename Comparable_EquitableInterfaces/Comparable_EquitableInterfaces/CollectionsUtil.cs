using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable_EquitableInterfaces
{
    public class CollectionsUtilExample
    {
        public static void CollectionsUtilEx()
        {
            Hashtable population1 = CollectionsUtil.CreateCaseInsensitiveHashtable();

            population1["Trapperville"] = 15;
            population1["Doggerton"] = 230;
            population1["New Hollow"] = 1234;
            population1["McHenry"] = 185;

            Console.WriteLine("Case insensitive hashtable results:\n");
            Console.WriteLine("{0}'s population is: {1}", "Trapperville", population1["trapperville"]);
            Console.WriteLine("{0}'s population is: {1}", "Doggerton", population1["DOGGERTON"]);
            Console.WriteLine("{0}'s population is: {1}", "New Hollow", population1["New hoLLow"]);
            Console.WriteLine("{0}'s population is: {1}", "McHenry", population1["MchenrY"]);

            SortedList population2 = CollectionsUtil.CreateCaseInsensitiveSortedList();

            foreach (string city in population1.Keys)
            {
                population2.Add(city, population1[city]);
            }

            // Select cities from the sorted list using mixed case.
            Console.WriteLine("\nCase insensitive sorted list results:\n");
            Console.WriteLine("{0}'s population is: {1}", "Trapperville", population2["trapPeRVille"]);
            Console.WriteLine("{0}'s population is: {1}", "Doggerton", population2["dOGGeRtON"]);
            Console.WriteLine("{0}'s population is: {1}", "New Hollow", population2["nEW hOLLOW"]);
            Console.WriteLine("{0}'s population is: {1}", "McHenry", population2["MchEnrY"]);
        }
    }
}
