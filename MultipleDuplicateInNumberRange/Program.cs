using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDuplicateInNumberRange
{
    /*Need to revisit-Given an array of n, with 2 number duplicate ( total of n+2) find the duplicate numbers
     * */
    class Program
    {
        static void Main(string[] args)
        {
            int[] dup = { 1, 3, 2, 4, 2, 3 };
            IList<int> result = DuplicateInArray(dup);
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static List<int> DuplicateInArray(int[] source)
        {
            List<int> duplicate = new List<int>();

            for(int count=0;count<source.Length;count++)
            {
                if (source[Math.Abs(source[count])] < 0)
                {
                    duplicate.Add(Math.Abs(source[count]));
                }
                else
                {
                    source[Math.Abs(source[count])] *= -1;
                }
            }

            return duplicate;
        }
    }
}
