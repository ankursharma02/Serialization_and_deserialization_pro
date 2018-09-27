using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abst_inter_demo
{
    class Dvd:Item
    {
        string title;
        string direct;
        string cata;
        void Item.IRead()
        {
            Console.WriteLine("Enter Dvd title:");
            title = Console.ReadLine();
            Console.WriteLine("Enter director name :");
            direct = Console.ReadLine();
            Console.WriteLine("Enter category : ");
            cata = Console.ReadLine();

        }
        void Item.Show()
        {
            Console.WriteLine("Dvd title: "+title+" director Name : "+direct+ " category :"+cata);

        }
    }
}
