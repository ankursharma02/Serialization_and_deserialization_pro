using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abst_inter_demo
{
    class Library
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===========Welcome to Library================== ");
            Console.WriteLine("Enter no of details u want to enter ");
            int no = Convert.ToInt32(Console.ReadLine());
            Item[] it = new Item[no];
            for (int i = 0; i < it.Length; i++)
            {
                lable1:
                Console.WriteLine("Enter Book or Dvd b/d ");
                char ch = Convert.ToChar(Console.ReadLine());
                if (ch.Equals('b'))
                {
                    it[i] = new Book();
                    it[i].IRead();
                }
                else if (ch.Equals('d'))
                {
                    it[i] = new Dvd();
                    it[i].IRead();
                }
                else
                {
                    Console.WriteLine("wrong input Enter b or d");
                    goto lable1;
                }
            }
            Console.WriteLine("enter detais are ");
            foreach (Item i in it)
            {
                i.Show();
            }
            Console.ReadLine();
        }
    }
}
