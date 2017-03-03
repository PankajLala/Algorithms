using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(987));
            Console.ReadLine();
        }

        public static int Sum(int n)
        {
            if (n < 1)
            {
                return n;
            }

            return n % 10 + Sum(n / 10);
        }
    }
}
