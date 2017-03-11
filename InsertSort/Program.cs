using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertSort
{
    /* O(n2) 
     * */
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 1, 6, 2, 4, 3 };
            InsertSort(ref arr);

            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static void InsertSort(ref int[] arr)
        {

            int j, key;
            for(int i = 1; i < arr.Length; i++) //Always start from the second element making it i
            {
                j = i - 1; //, and j one less then i
                key = arr[i]; // capture the ith element as key

                while(j>=0 && arr[j] > key) // till  the item on left of i are less then key and j >=0 
                {
                    arr[j + 1] = arr[j]; //keep on shifting left element to right
                    j--;                 // also keep on moving towards left 
                }

                arr[j + 1] = key; // insert the key at the last position of j
            }
        }
    }
}
