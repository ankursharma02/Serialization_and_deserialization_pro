using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abst_inter_demo
{
    public delegate void Print(int value);
    class Deligate_demo2
    {
        

        static void Main(string[] args)
        {
            Print printDel = PrintNumber;
            printDel += PrintHexadecimal;
            printDel += PrintMoney;

            printDel(100000);
            Console.ReadLine();
        }
        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: "+ num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: "+ money);
        }

        public static void PrintHexadecimal(int dec)
        {
            Console.WriteLine("Hexadecimal: "+ dec);
        }
    }
}
