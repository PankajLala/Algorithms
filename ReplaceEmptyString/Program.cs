using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceEmptyString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceEmptyString("my name is a b c"));
            Console.ReadLine();
        }

        public static string ReplaceEmptyString(string str)
        {
            int countEmpty = 0;
            foreach(char c in str)
            {
                if (Char.IsWhiteSpace(c))
                {
                    countEmpty++;
                }
            }

            if (countEmpty <= 0)
            {
                return str;
            }
            else
            {
                int len = str.Length + countEmpty * 2;
                char[] chr = new char[len];
                int i=0;
                foreach (var c in str)
                {
                    if (Char.IsWhiteSpace(c))
                    {
                        chr[i] = '%';
                        chr[i + 1] = '2';
                        chr[i + 2] = '0';
                        i += 3;
                    }
                    else
                    {
                        chr[i]= c;
                        i++;
                    }
                }

                return new string(chr);

            }


        }
    }
}
