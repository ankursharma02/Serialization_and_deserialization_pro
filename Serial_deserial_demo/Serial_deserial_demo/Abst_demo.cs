using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serial_deserial_demo
{
    abstract class Abst_demo
    {
        public void show()
        {
            Console.WriteLine("Show()");
        }
        abstract public void demo();
    }
    class X : Abst_demo
    {
        public override void demo()
        {

            Console.WriteLine("Demo()");
        }
        public static void Main()
        {
            X x1 = new X();
            x1.demo();
            x1.show();
            Console.ReadLine();
        }

    }
}
