using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationString
{
    class Program
    {
        static void Main(string[] args)
        {
            Permute p = new Permute();
            string c = "sagiv";
            char[] c2 = c.ToCharArray();
            /*calling the permute*/
            p.Setup(c2);

            Console.ReadLine();
        }



        class Permute
        {
            private  void Swap(ref char a, ref char b)
            {
                if (a == b) return;
                a ^= b;
                b ^= a;
                a ^= b;
            }

            public void Setup(char[] list)
            {
                int x = list.Length - 1;
                go(list, 0, x);
            }

            private void go(char[] list, int k, int m)
            {
                int i;
                if (k == m)
                {
                    Console.WriteLine(list);
                }
                else
                {
                    for(i = k; i <= m; i++)
                    {
                        Swap(ref list[k], ref list[i]);
                        go(list, k + 1, m);
                        Swap(ref list[k], ref list[i]);
                    }
                }

            }
        }
    }
}
