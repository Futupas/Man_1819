using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Smart Division by Futupas.";
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                while (true)
                {
                    int a, b;
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());

                    Console.WriteLine(dec.Divide(a, b));
                    Console.WriteLine();
                }
                
                //for (int i = 1; i < 100; i++)
                //{
                //    dec d = dec.Divide(100, i);
                //    Console.WriteLine("100 / {0} = [{1}] {2}", i, d.period.Length, d.ToString());
                //}
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
    class dec
    {
        public dec()
        {
            this.integer = "";
            this.fraction = "";
            this.period = "";
        }
        public string integer = "";
        public string fraction = "";
        public string period = "";
        public override string ToString()
        {
            if (this.period == "")
            {
                if (this.fraction == "" || this.fraction == "0")
                {
                    return this.integer;
                }
                else
                {
                    return this.integer + "." + this.fraction;
                }
            }
            else
            {
                return this.integer + "." + this.fraction + "(" + this.period + ")";
            }
        }
        public static dec Divide(int a, int b)
        {
            int c, o;
            dec answer = new dec();
            string ac = "";
            int[] usedostachas = new int[b];
            for (int i = 0; i < usedostachas.Length; i++) usedostachas[i] = -1;

            c = a / b;
            o = a % b;
            answer.integer = c.ToString();
            a = o;
            usedostachas[o] = ac.Length;
            a = a * 10;
            
            for (int j = 0; j < b; j++)
            {
                c = a / b;
                o = a % b;
                ac += c.ToString();
                if (o == 0)
                {
                    answer.fraction = ac;
                    answer.period = "";
                    return answer;
                }
                if (usedostachas[o] != -1)
                {
                    int f = usedostachas[o];
                    answer.fraction = ac.Substring(0, f);
                    answer.period = ac.Substring(f, ac.Length - f);
                    return answer;
                }
                usedostachas[o] = ac.Length;
                a = o;
                a = a * 10;
            }
            throw new Exception("The fraction is not periodic.");
        }
    }
}
