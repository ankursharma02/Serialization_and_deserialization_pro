using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abst_inter_demo
{
    abstract class A
    {
        abstract public void test1();
        abstract public void test2();
        abstract public void test3();
    }
    abstract class B:A
    {
	  public  override void test1()

    {
            Console.WriteLine("B.test1()");
        }
    }

    abstract class C:B
    {
	   public override  void  test2()

    {
            Console.WriteLine("C.test2()");
        }
    }
    class O :C
    {
	public override void test3()

    {
            Console.WriteLine("D.test3()");
        }
    }
    class Abs_O
    {
        public static void Main()
        {
            //A a1=new A();
            //B b1=new B();
            //C c1=new C();
            O o1 = new O();
            o1.test1();
            o1.test2();
            o1.test3();
            Console.WriteLine("done");
            Console.ReadLine();
        }
    }




    //abstrct class should have also min one constr if we not provid any const in abstr class then compiler create default consrt
    //when abst class cosntr is exicuting

}
