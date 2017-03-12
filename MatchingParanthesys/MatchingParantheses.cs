using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingParantheses
{
    class MatchingParantheses
    {
        static void Main(string[] args)
        {

            Console.WriteLine(IsMatch("(){}[]"));
            Console.ReadLine();
        }

        public static bool IsMatch(string str)
        {
            if (String.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            Stack<char> characters = new Stack<char>(str.Length);

            foreach(var item in str.ToCharArray())
            {
                if(item.Equals('(') || item.Equals('{') || item.Equals('['))
                {
                    characters.Push(item);
                }

                if(item.Equals(')') || item.Equals('}') || item.Equals(']'))
                {
                    char last = characters.Peek();

                    if(item.Equals(')') && last.Equals('(') || item.Equals('}') && last.Equals('{') || item.Equals(']') && last.Equals('['))
                    {
                        characters.Pop();
                    }
                }
            }

            return characters.Count() == 0;
        }
    }
}
