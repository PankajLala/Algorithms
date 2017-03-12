using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(IsAnagram2("gaana", "adang"));
            Console.ReadLine();
        }

        /*Poor implementation in terms of space and time complexity
         * */
        public static bool IsAnagram1(string str1, string str2)
        {
            char[] char1 = str1.ToLower().ToCharArray();
            char[] char2 = str2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            if (new string(char1) == new string(char2))
            {
                return true;
            }

            return false;
        }

        /*
         * Better in space and time complexity as hashtable ( generic dictionary) has time complexity for search and delete is O(1) 
         * thus making  overall comlexity as O(2N)?. 
        */
        public static bool IsAnagram2(string str1, string str2)
        {
            Dictionary<char, int> collection = new Dictionary<char, int>();
            
            //Add the number of times a character is occuring in first string.
            foreach(char c in str1.ToLower().ToCharArray())
            {
                int count = 0;
                collection.TryGetValue(c, out count);
                count++;
                collection[c] = count;
            }

            //then start reducing the count of characters in the dictionary while iterating the second string (if character is found) and finally removing the 
            //character altogether. If by the end of the second strings iteration the dictionary is empty then its an anagram
            foreach(char c in str2.ToLower().ToCharArray())
            {
                if (!collection.ContainsKey(c))
                {
                    return false;
                }

                if(--collection[c] == 0)
                {
                    collection.Remove(c);
                }

            }

            return collection.Count == 0;
        }
    }
}
