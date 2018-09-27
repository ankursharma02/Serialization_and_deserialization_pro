using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abst_inter_demo
{
    
    class Book:Item
    {
        string book_name;
        string Author;
        string publication;
        void Item.IRead()
        {

            Console.WriteLine("Enter Book Name");
            book_name = Console.ReadLine();
            Console.WriteLine("Enter Author ");
            Author = Console.ReadLine();
            Console.WriteLine("Enter Publication:");
            publication = Console.ReadLine();
        }
        void Item.Show()
        {
            Console.WriteLine("Book :" + book_name + " Book Author : " + Author + " publication : " + publication);
        }
    }
}
