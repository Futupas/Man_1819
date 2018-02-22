using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "0123456789";
            string str1 = str.Substring(0, str.IndexOf('5')-0);
            string str2 = str.Substring(str.IndexOf('5'), str.Length-str.IndexOf('5'));
            Console.WriteLine(str);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}
