//TODO: User XOR approach to find the set of missing numbes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleMissingNumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9,1, 2, 4, 5, 6,9,  7, 9 };
            foreach(int item in MissingNumber(arr))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        /*
         * */
        public static List<int> MissingNumber(int[] arr)
        {
            int[] sortedDistinctArray = arr.Distinct().ToArray();
            Array.Sort(sortedDistinctArray);
            return Enumerable.Range(sortedDistinctArray[0], sortedDistinctArray[sortedDistinctArray.Length - 1]).Except(sortedDistinctArray.Cast<int>()).ToList();
        }
    }
}
