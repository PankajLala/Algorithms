using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("super"));
            Console.ReadLine();
        }

        public static bool IsPalindrome(string str)
        {
            int len = str.Length;
            int middle = len / 2;
           
            for(int count = 0; count < middle; count++)
            {
                if(str[count] != str[len - 1 - count])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPalindrome1(string str)
        {
            char[] c = str.ToCharArray();
            c.Reverse();
            return new String(c) == str;  
        }
    }
}
