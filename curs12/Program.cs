using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            //int[] s = new int[n];
            bool[] b = new bool[n];
            int p = 4;
            //BKAranj(0, n, p, s, b);
            //BKComb(0, n, p, s, b);
            int[] s = new int[n + 1];
            s[0] = 0;
            BKCombv2(1, n, p, s);
        }

        private static void BKCombv2(int k, int n, int p, int[] s)
        {//conditia e la generare
            if (k > p)
            {
                for (int i = 1; i <= p; i++)
                {
                    Console.Write(s[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = s[k -1] + 1; i <= n; i++)
                {
                    s[k] = i;
                    BKCombv2(k + 1, n, p, s);
                }
            }
        }

        private static void BKComb(int k, int n, int p, int[] s, bool[] b)
        {//conditia e la afisare
            if (k >= p)
            {
                bool ok = true;
                for (int i = 0; i < p - 1; i++)
                {
                    if (s[i] > s[i + 1])
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    for (int i = 0; i < p; i++)
                    {
                        Console.Write(s[i] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!b[i])
                    {
                        b[i] = true;
                        s[k] = i + 1;
                        BKComb(k + 1, n, p, s, b);
                        b[i] = false;
                    }
                }
            }
        }

        private static void BKAranj(int k, int n, int p, int[] s, bool[] b)
        {
            if (k >= p)
            {
                for (int i = 0; i < p; i++)
                {
                    Console.Write(s[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!b[i])
                    {
                        b[i] = true;
                        s[k] = i + 1;
                        BKAranj(k + 1, n, p, s, b);
                        b[i] = false;
                    }
                }
            }
        }
    }
}
