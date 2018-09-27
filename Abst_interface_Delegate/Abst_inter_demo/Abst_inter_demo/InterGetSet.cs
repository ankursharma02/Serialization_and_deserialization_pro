using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abst_inter_demo
{
    interface ILeft
    {
        int P { get; }
    }
    interface IRight
    {
        int P();
    }
    class InterGetSet:ILeft,IRight
    {
        
        int ILeft.P { get { return 11; } }
        public int  P() { return 22; }
        public static void Main(string[] args)
        {
            InterGetSet ig = new InterGetSet();
            ILeft il;
            IRight ir;
            il = ig;
            ir = ig;
            Console.WriteLine(il.P);
            Console.WriteLine(ir.P());
            Console.ReadLine();
        }
    }
}
