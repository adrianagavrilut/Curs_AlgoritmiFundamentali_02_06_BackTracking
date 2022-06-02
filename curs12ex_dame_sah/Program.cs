using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs12ex_dame_sah
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            int[] s = new int[n];
            bool[] b = new bool[n];
            BKP(0, n, s, b);
        }

        public static void BKP(int k, int n, int[] s, bool[] b)
        {
            if (k >= n)
            {
                bool ok = true;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (Math.Abs(i - j) == Math.Abs(s[i] - s[j]))
                        {
                            ok = false;
                            break;
                        }
                    }
                }
                if (ok)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (s[i] == j)
                            {
                                Console.Write("[x]");
                            }
                            else
                            {
                                Console.Write("[ ]");
                            }
                        }
                        Console.WriteLine();
                        
                        //Console.Write(s[i] + " ");
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
                        s[k] = i;
                        BKP(k + 1, n, s, b);
                        b[i] = false;
                    }
                }
            }
        }
    }
}
