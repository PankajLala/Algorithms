using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimaltoBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertToBinary(4));
            Console.ReadLine();
        }

        public static double ConvertToBinary(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            return (n % 2) + 10 * ConvertToBinary(n / 2);
        }
    }
}
