using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class BaseClass
    {
        int a = 10;
        public void show()
        {
            Console.WriteLine("value of a {0}", a);
        }
        public BaseClass(int b)
        {
            Console.WriteLine("Value num  bas{0}", b);
        }
    }
    public class Derived : BaseClass
    {
        public void getshow()
        {

            show();
        }
        public Derived(int p) : base(p)
        {
            Console.WriteLine("Value num der {0}", p);
        }
    }


}
