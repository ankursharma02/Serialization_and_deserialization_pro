using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serial_deserial_demo
{
    interface IInterface_demo
    {
        void show();
    }
    interface IA
    {
        void showA();

    }
    interface IB : IInterface_demo, IA
    {
        void showB();

    }
    public class Y : IB
    {
        void IInterface_demo.show()
        {
            Console.WriteLine("Show()");

        }
        void IA.showA()
        {
            Console.WriteLine("ShowA()");
        }
        void IB.showB()
        {
            Console.WriteLine("showB()");
        }

    }
    class D
    {
        static void Main()
        {
            Y y1 = new Y();
            IInterface_demo d;
            IA a;
            IB b;
            a = (IA)y1;
            b = (IB)y1;
            d = (IInterface_demo)y1;
            a.showA();
            b.showB();
            d.show();
 
            Console.ReadLine();

        }

    }
}