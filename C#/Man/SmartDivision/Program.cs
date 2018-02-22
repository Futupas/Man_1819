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
            while (true)
            {
                int a, b;
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                Console.WriteLine(Divide(a, b).ToString());
                Console.ReadLine();
                Console.WriteLine();
            }
            //Console.ReadLine();
        }

        static dec Divide(int a, int b)
        {
            int c, o;
            dec answer = new dec();

            c = a / b;
            o = a % b;
            answer.integer = c.ToString();
            a = o;
            a = a * 10;

            string ac = "";
            int[] usedostachas = new int[b];
            for (int i = 0; i < usedostachas.Length; i++) usedostachas[i] = -1;

            for (int j = 0; j < b; j++)
            {
                c = a / b;
                o = a % b;
                if (usedostachas[o] != -1) {
                    int f = usedostachas[o];
                    answer.fraction = ac.Substring(0, f);
                    answer.period = ac.Substring(f, ac.Length - f);
                    return answer;
                }
                usedostachas[o] = ac.Length;
                ac += c.ToString();
                a = o;
                a = a * 10;
            }
            return answer;
        }
    }
    class dec
    {
        public string integer = "";
        public string fraction = "";
        public string period = "";
        public override string ToString()
        {
            return this.integer + "." + this.fraction + "(" + period + ")";
        }
    }
}
