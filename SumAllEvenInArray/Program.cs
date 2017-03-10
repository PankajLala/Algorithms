using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAllEvenInArray
{
    /*Given and array of ints, find the sum of all even numbers*/
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 4, 12, 2, 7 };
            Console.WriteLine(SumEven(arr));
            Console.ReadLine();
        }


        private static int SumEven(int[] arr)
        {
            var sum = 0;
            foreach(var item in arr)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }

            return sum;
        }
    }
}
