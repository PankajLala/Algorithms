using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateCharString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(IsUnique("abcdfe"));
            Console.ReadLine();
        }

        //Without using extra data structure, otherwise we can use a dictionary<char,int> and verify if key is duplicate
        public static bool IsUnique(string str)
        {
            string temp1;

            for(int i = 0; i < str.Length; i++)
            {
                //get a character
                temp1 = str.Substring(i, 1);

                //verify if this character is in the string
                foreach(char c in str.Substring(i+1).ToCharArray())
                {
                    if(temp1 == c.ToString())
                    {
                        return false;
                    }
                }

            }
            return true;
        }
    }
}
