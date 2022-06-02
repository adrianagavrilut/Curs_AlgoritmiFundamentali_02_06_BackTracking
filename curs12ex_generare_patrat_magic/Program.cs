using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs12ex_generare_patrat_magic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
            int[] s = new int[n];
            bool[] b = new bool[n];
            BKP(0, n, s, b);
        }

        public static void BKP(int k, int n, int[] s, bool[] b)
        {
            if (k >= n)
            {
                int sl1 = s[0] + s[1] + s[2]; //suma pe linia 1
                int sl2 = s[3] + s[4] + s[5];
                int sl3 = s[6] + s[7] + s[8];
                int sc1 = s[0] + s[3] + s[6]; // suma pe coloana 1
                int sc2 = s[1] + s[4] + s[7];
                int sc3 = s[2] + s[5] + s[8];
                int sd1 = s[0] + s[4] + s[8]; // suma pe diagonala principala
                int sd2 = s[2] + s[4] + s[6];
                if (sl1 == sl2 && sl1 == sl3 && sl1 == sl3 && sl1 == sc1 && sl1 == sc2 && sl1 == sc3 && sl1 == sd1 && sl1 == sd2)
                {
                    int l = 0;
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(s[i] + " ");
                        l++;
                        if (l == 3)
                        {
                            Console.WriteLine();
                            l = 0;
                        }
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
                        BKP(k + 1, n, s, b);
                        b[i] = false;
                    }
                }
            }
        }
    }
}
