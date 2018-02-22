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
                for (int i = 1; i <= 100; i++)
                {
                    //Console.WriteLine();
                    Divide(100, i);
                }
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 1; i <= 100; i++)
                {
                    //Console.WriteLine();
                    Divide(i, 100);
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
            int d, ch;
            int[] numsac = new int[500];

            d = a / b;
            ch = a % b;
            a = ch * 10;
            for (int i = 0; i < 500; i++)
            {
                d = a / b;
                ch = a % b;
                numsac[i] = d; // number
                a = ch * 10;
            }

            int numac = 0;
            for (int i = 1; i <= 200; i++)
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

            string aftercomma = "";
            for (int i = 0; i < 50; i++)
            {
                aftercomma += numsac[i].ToString();
            }

            Console.WriteLine("{0}: {1} - {2}", b, numac, aftercomma);

            return numac;
        }
    }
}
