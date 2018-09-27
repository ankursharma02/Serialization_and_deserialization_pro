using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abst_inter_demo
{
    class Inter_Test
    {
        static void Main()
        {
            SampleClass sc = new SampleClass();
            IControl ctrl = sc;
            ISurface srfc = sc;

            // The following lines all call the same method.
            sc.Paint();
            ctrl.Paint();
            srfc.Paint();
            Console.ReadLine();
        }
    }


    interface IControl
    {
        void Paint();
    }
    interface ISurface
    {
        void Paint();
    }
    class SampleClass : IControl, ISurface
    {
        // Both ISurface.Paint and IControl.Paint call this method. 
       void IControl.Paint()
        {
            Console.WriteLine("IControl.Paint()");
        }
        void ISurface.Paint()
        {
            Console.WriteLine("ISurface.Paint()");

        }
        public void Paint()
        {
            Console.WriteLine("in sample class ");
        }
    }

}
