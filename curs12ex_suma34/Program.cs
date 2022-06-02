using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs12ex_suma34
{
    class Program
    {
        static int nr = 0;
        static void Main(string[] args)
        {
            int n = 16;
            int p = 4;
            int[] s = new int[n];
            BKComb(1, n, p, s);
            Console.WriteLine(nr);
        }

        private static void BKComb(int k, int n, int p, int[] s)
        {
            if (k > p)
            {
                int sum = 0;
                for (int i = 1; i <= p; i++)
                {
                    sum += s[i];
                }
                if (sum == 34)
                {
                    nr++;
                    for (int i = 1; i <= p; i++)
                    {
                        Console.Write(s[i] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = s[k - 1] + 1; i <= n; i++)
                {
                    s[k] = i;
                    BKComb(k + 1, n, p, s);
                }
            }
        }
    }
}
