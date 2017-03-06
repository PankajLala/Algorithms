using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersWithinRange
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] primes = AllPrimes(10);

            for(int prime = 2; prime < 10; prime++)
            {
                if (primes[prime])
                {
                    Console.WriteLine(prime);
                }
            }
            Console.ReadLine();
        }

        //https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes

        public static bool[] AllPrimes(int num)
        {
            bool[] e = new bool[num];

            for(int i = 2; i < num; i++)
            {
                e[i] = true; //initialize all to true;
            }

            for(int j=2; j < num; j++)
            {
                if (e[j])
                {
                    for(long p = 2; p * j < num; p++)
                    {
                        e[p * j] = false;
                    }
                }
            }

            return e;
        }
    }
}
