using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abst_inter_demo
{
    public interface Drawable
    {
        void draw();

    }
    public class Rectangle1 : Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle");
        }
    }
    public class Circle1 : Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing circle ");
        }
    }
    class Interf_test
    {
        public static void Main(string[] args)
        {
            Drawable d;
            d= new Rectangle1();
            d.draw();
            d = new Circle1();
            d.draw();
            Console.ReadLine(); 

        }
    }
}
