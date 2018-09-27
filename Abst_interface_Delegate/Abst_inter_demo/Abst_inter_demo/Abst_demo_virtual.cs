using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abst_inter_demo
{
    public class D
    {
        public virtual void DoWork(int i)
        {
            Console.WriteLine("virtual doWork ");
        }
    }

    public abstract class E : D
    {
        public abstract override void DoWork(int i);
    }

    public class Abst_demo_virtual : E
    {
        public override void DoWork(int i)
        {
            Console.WriteLine("F.DoWork()");
        }
        public static void Main(string[] args)
        {
            Abst_demo_virtual f = new Abst_demo_virtual();
            D d = new D();
            f.DoWork(1);
            d.DoWork(2);
            Console.ReadLine();
        }
    }
    
}
