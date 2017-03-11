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
            int[] dup = { 2,3,0,1,2,5,3 };
            IList<int> result = DuplicateInArray(dup);
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        //'Does not works when array contain 0!

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

        //works but not using the index
        public static List<int> DuplicateInArray1(int[] source)
        {
            Dictionary<int, int> dup = new Dictionary<int, int>();
            List<int> list = new List<int>();

            int count = 0;
            foreach(var item in source)
            {
                count = 0;
                dup.TryGetValue(item, out count);

                if (count==1)
                {
                    list.Add(item);
                }
                else
                {
                    dup[item] = 1;
                }
            }

            return list;
        }



    }
}
