using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class primeCheck
    {
        public static bool isPrime(int n)
        {
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        public static void printPrimes()
        {
            Predicate<int> checkPrime = p => isPrime(p);
            for(int i=2; i<=10; i++)
            {
                if(checkPrime(i))
                    Console.WriteLine(i);
            }
        }
    }
    
}
