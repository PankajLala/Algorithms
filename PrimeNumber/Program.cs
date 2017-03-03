using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    //Prime number is only divisible by 1 and itself
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(15));
            Console.ReadLine();
        }

        public static bool IsPrime(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;

            //No need to verify till n-1th number, verify till sqaure root of num
            int sqrRoot = Convert.ToInt16(Math.Sqrt(num));

            for(int i = 2; i < sqrRoot; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;

        }
    }
}
