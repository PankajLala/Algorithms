using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementsInString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Count("Pankaj lala"));
            Console.ReadLine();
        }

        public static string Count(string str)
        {
            var strArray = str.ToCharArray();
            Array.Reverse(strArray);
            return new String(strArray);
            
        }
    }
}
