using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairInArrayHavingSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7,8,9,3,2};
            Dictionary<int, int> result = PairsHavingSum(arr,10);
            foreach(KeyValuePair<int, int> item in result)
            {
                Console.WriteLine(item.Key +" , " + item.Value);
            }
            Console.ReadLine();
        }

        public static Dictionary<int, int> PairsHavingSum(int[] arr, int sum)
        {
            Dictionary<int, int> coll = new Dictionary<int, int>();
            Dictionary<int, int> collReturn = new Dictionary<int, int>();

            foreach (int item  in arr)
            {
                if (!coll.ContainsKey(sum-item))
                {
                    coll[item] = sum-item;
                }
                else
                {
                    coll.Remove(sum - item);
                    collReturn[item] = sum - item;
                }
            }

            return collReturn;
        }
    }
}
