using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Triangle
    {
        int a;
        public static int staticint;
        public static void setValue(int par)
        {
            staticint = par;

        }
        public static void getValue()
        {
            Console.WriteLine("Value is {0}", staticint);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            //Triangle obj1 = new Triangle();

            //Triangle.setValue(10);
            //Triangle.getValue();


            //Derived der = new Derived(20);

            //BaseClass bas = new BaseClass(10); 
            //der.show();
            //der.show();
            //der.getshow();

            ///******** ABSTRACT *******////
            
            //Grand o = new Grand();
            //o.Add(23, 0);
            //o.show();
            //o.Add(1, 4);
            //o.show();

            //BaseOne ob = new BaseOne();
            //ob.Add(23, 0);
            //ob.show();
            //ob.Add(1, 4);
            //ob.show();
            //Console.ReadKey();

            //******//

            ///********* Interface *********////
            
            //Interface1 ob = new Derivedone();
            //ob.display("test-1");
            //ob.display("test-1","test-2");
            

            //Interface1 ob2 = new Derivedtwo();
            //ob2.display("test-11");
            //ob2.display("test-11", "test-21");

            //Interface2 ob3 = new Derivedone();
            //Console.WriteLine(ob3.getData(898));
            //Console.ReadKey();

            //******//

            ///********* Property / Encapsulation *********////
            ///
            Encapsulation e1 = new Encapsulation();
            e1.setData("val-1");
            Console.WriteLine("val {0}", e1.getData());
            

            e1.Data1 = "test-1";
            Console.WriteLine("val {0}", e1.Data1);
            Console.ReadKey();

        }
    } 
}
