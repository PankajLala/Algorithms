using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerofN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pwr(5, 3));
            Console.ReadLine();
        }

        public static int Pwr(int num, int exp)
        {
            if (num == 1) return 0;
            if (exp == 0) return 1;
            return num * Pwr(num, exp - 1);
        }
    }
}
