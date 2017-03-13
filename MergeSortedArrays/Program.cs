using System;
using System.Collections;

//TODO: Not working :(
namespace MergeSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr1 = new ArrayList(10);
            arr1.Add(1);
            arr1.Add(5);
            arr1.Add(7);
            arr1.Add(10);
            arr1.Add(15);
            arr1.Add(null);



            int[] arr2 = { 2,8 ,13};

            MergeArrays(arr1, arr2);
            Console.ReadLine();
        }

        public static void MergeArrays(ArrayList arr1, int[] arr2)
        {
            int arr1Index = arr1.Count - 1;
            int arr2Index = arr2.Length - 1;

            int newIndex = arr1Index + arr2Index - 1;

            while ( arr1Index > 0 && arr2Index > 0)
            {
                if((int)arr1[arr1Index-1] > arr2[arr2Index - 1])
                {
                    arr1[newIndex] = arr1[arr1Index - 1];
                    arr1Index--;
                }
                else
                {
                    arr1[arr1Index] = arr2[arr2Index - 1];
                    arr2Index--;
                }
                newIndex--;
            }

            while (arr2Index > 0)
            {
                arr1[newIndex] = arr2[arr2Index - 1];
                arr2Index--;
                newIndex--;
            }

            foreach(var item in arr1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
