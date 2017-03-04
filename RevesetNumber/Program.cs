//TODO: Recursive approach
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevesetNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseIterative(765));
            Console.ReadLine();
        }

        /* 
         * Making char arry then reversing same and then creating string and then int. Phew bad space complexity
        */
        public static int ReverseUsingArray(int num)
        {
            string textValue = num.ToString().TrimStart('-');

            char[] valueChars = textValue.ToCharArray();
            Array.Reverse(valueChars);
            string reversedValue = new string(valueChars);
            int reversedInt = int.Parse(reversedValue);

            if (num < 0)
                reversedInt *= -1;

            return reversedInt;
        }

        public static int ReverseIterative(int num)
        {
            int remainder=0, sum = 0;

            while (num > 0)
            {
                remainder = num % 10;
                sum = sum * 10 + remainder;
                num = num / 10;
            }

            return sum;
        }

    }
}

