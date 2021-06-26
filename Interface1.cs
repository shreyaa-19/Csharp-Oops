using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface Interface1
    {
         void display(string s1);
         void display(string s1, string s2);
    }

    public interface Interface2
    {
        int getData(int p);
    }
    public class Derivedone: Interface1, Interface2
    {
        public void display(string s1)
        {
            Console.WriteLine(s1);
        }
        public void display(string s1, string s2)
        {
            Console.WriteLine("{0}, {1}",s1,s2);
        }

        //***Cant access show() because Derivedone is child of Interfae1,
        //***and show() is not defined in Interface1

        //public void show()
        //{
        //    Console.WriteLine("show 12");
        //}

        public int getData(int p)
        {
            return p;
        }

    }

    public class Derivedtwo : Interface1
    {
        public void display(string s1)
        {
            Console.WriteLine(s1);
        }
        public void display(string s1, string s2)
        {
            Console.WriteLine("{0}, {1}", s1, s2);
        }
    }

}
