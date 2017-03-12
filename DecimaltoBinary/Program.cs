using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimaltoBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertToBinary(343));
            Console.ReadLine();
        }

        //Decimal is base then binary is base 2. Thus keep on adding the reminder of %2

        public static double ConvertToBinary(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            return (n % 2) + 10 * ConvertToBinary(n / 2);
        }
    }
}
