using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostCommonNumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20] { 3, 6, 8, 5, 3, 5, 7, 6, 4, 3, 2, 3, 5, 7, 6, 4, 3, 4, 5, 7 };

            MaximumOccurance(array);
            MaximumOccuranceLinq(array);
            Console.ReadLine();
        }

        public static void MaximumOccurance(int[] array)
        {
            SortedDictionary<int, int> hs = new SortedDictionary<int, int>();
            foreach(int item in array)
            {
                int count;
                hs.TryGetValue(item, out count);
                count++;
                hs[item] = count;
                
            }

            int mostCommonNumber = 0, occurance = 0;

            foreach(KeyValuePair<int,int> entry in hs)
            {
                if (entry.Value > occurance)
                {
                    occurance = entry.Value;
                    mostCommonNumber = entry.Key;
                }
               
            }

            Console.WriteLine(string.Format("{0}-{1}", occurance, mostCommonNumber));
        }

        public static void MaximumOccuranceLinq(int[] array)
        {
            var grps = array.GroupBy(x => x);
            var largets = grps.OrderByDescending(x => x.Count()).First();
            Console.WriteLine("" + largets.Key, largets.Count());
        }
    }
}
