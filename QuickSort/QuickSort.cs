using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    /* Partition and divide: Take a random Pivot value, iterate to have all the items < Pivot to left and all item > Pivot to right
     * append all three.
     * space complexity: O(nlogn)
     * time complexity: O(nlogn)
     * */
    class QuickSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 1, 6, 2, 4, 3 };
            IEnumerable<int> result = QuickSortAlgo(arr);
            
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

            int[] arr2 = { 5, 1, 6, 2, 4, 3 };

            List<int> arr1 = new List<int>(arr2);
            List<int> result2 = QuickSortAlgo2(arr1);

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static IEnumerable<int> QuickSortAlgo(IEnumerable<int> i)
        {
            if (!i.Any()) return i;
            var p = i.ElementAt(new Random().Next(0, i.Count() - 1));
            return QuickSortAlgo(i.Where(x => x < p)).Concat(i.Where(x => x == p)).Concat(QuickSortAlgo(i.Where(x => x >  p)));
        }

        public static List<int> QuickSortAlgo2(List<int> i)
        {
            if (i.Count() < 2) return i;
            var pivot = new Random().Next(i.Count());
            int val = i[pivot];
            var lesser = new List<int>();
            var greater = new List<int>();

            foreach(var item in i)
            {
                if(item != val){
                    if (item < val) lesser.Add(item);
                    if (item >= val) greater.Add(item);
                }
            }


            var merged = QuickSortAlgo2(lesser);
            merged.Add(val);
            merged.AddRange(QuickSortAlgo2(greater));
            return merged;

        }
    }
}
