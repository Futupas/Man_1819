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
                int a, b, d, ch, nac; //a/b=c
                                      //dilene, chastka, numbers after comma
                Console.WriteLine("a / b = c");
                Console.Write("a = "); a = Int32.Parse(Console.ReadLine());
                Console.Write("b = "); b = Int32.Parse(Console.ReadLine());
                Console.Write("nac = "); nac = Int32.Parse(Console.ReadLine());
                Console.Clear();

                d = a / b;
                ch = a % b;
                Console.WriteLine(d);
                Console.WriteLine(".");
                a = ch * 10;
                for (int i = 0; i < nac; i++)
                {
                    d = a / b;
                    ch = a % b;
                    Console.WriteLine(d);
                    a = ch * 10;
                    Thread.Sleep(10);
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
    }
}
