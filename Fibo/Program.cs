using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 12; i++)
            {
                Console.Write("{0} ", Fibo(i));
            }
            Console.ReadLine();
        }

        public static int Fibo(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Fibo(n - 1) + Fibo(n - 2);
        }
    }
}
