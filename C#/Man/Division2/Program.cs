using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, d, ch, cile; //a/b=c
                                       //dilene, chastka, numbers after comma
                Console.WriteLine("a / b = c");
                string s = Console.ReadLine();
                string[] ab = s.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                a = Int32.Parse(ab[0]); b = Int32.Parse(ab[1]);
                int[] numsac = new int[100];

                Console.Clear();

                d = a / b;
                ch = a % b;
                cile = d;
                a = ch * 10;
                for (int i = 0; i < 100; i++)
                {
                    d = a / b;
                    ch = a % b;
                    numsac[i] = d; // number
                    a = ch * 10;
                }

                int numac = 0;
                for (int i = 1; i <= 20; i++)
                {
                    bool isntperiodic = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (numsac[j] != numsac[i + j]) isntperiodic = true;
                    }
                    if (!isntperiodic)
                    {
                        numac = i;
                        break;
                    }
                }

                if (numac == 0)
                {
                    Console.WriteLine("non-periodic fraction");
                }
                else
                {
                    string aftercomma = "";
                    for (int i = 0; i < numac; i++)
                    {
                        aftercomma += numsac[i].ToString();
                    }
                    Console.WriteLine(cile.ToString() + ".(" + aftercomma + ")");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        static int Divide(int a, int b)
        {

        }
    }
}
