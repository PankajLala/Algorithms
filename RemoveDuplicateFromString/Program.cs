using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveDuplicateChars("Pankaj");
            Console.ReadLine();
        }

        private static void RemoveDuplicateLinq(string str)
        {
            var usedList = new List<char>();
            foreach(char c in str)
            {
                if (!usedList.Exists(x => x.Equals(c)))
                {
                    usedList.Add(c);
                }
            }

            usedList.ForEach(x => Console.Write(x));
        }

        private static void RemoveDuplicateChars(string key)
        {

            // Store the result in this string.
            string result = "";

            // Loop over each character.
            foreach (char value in key)
            {
                // See if character is in the table.
                if (result.IndexOf(value) == -1)
                {
                    result += value;
                }
            }
             Console.WriteLine(result);
        }

    }
}
