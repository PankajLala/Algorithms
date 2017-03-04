using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SwapXOR(65, 43);
            Console.ReadLine();
        }

        public static void Swap1(int x, int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine("x: " +  x + " , y: " +  y);
        }

        public static void SwapXOR(int x, int y)
        {
            x ^= y;
            y ^= x;
            x ^= y;

            Console.WriteLine("x: " + x + " , y: " + y);
        }
    }
}
