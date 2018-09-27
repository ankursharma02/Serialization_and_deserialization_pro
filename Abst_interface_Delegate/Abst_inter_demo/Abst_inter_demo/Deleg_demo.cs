using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abst_inter_demo
{
    class Deleg_demo
    {
        public delegate void Print(int value);
        static void Main(string[] args)
        {
            Print p = PrintNumber;
            p(1000);
            p(200);
            p = Printmoney;
            p(30030);
            p(22002);
            Console.ReadLine();

        }
        public static void PrintNumber(int n)
        {
            Console.WriteLine("Number =" + n);
        }
        public static void Printmoney(int n)
        {
            Console.WriteLine("Money = " + n);
        }
    }
}
