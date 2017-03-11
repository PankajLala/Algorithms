using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{

    //Time-complexity: O(n2);
    //Space-Complexity: O(1)
    //Stablility: Stable (a stable sort algo is one which preserves the order of objects with equal keys)
    class BubbleSort
    {
        static void Main(string[] args)
        {

            int[] arr = { 5, 1, 6, 2, 4, 3 };
            var len = arr.Length;

            int temp = 0;

            for(int i= 0; i < len-1; i++)
            {
                for(int j = 0; j < len-1 - i; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j + 1] = temp;
                    }
                }
            }

            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
