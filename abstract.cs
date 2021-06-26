using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Abst
    {
        private int a;
        private int b;
        protected int add;
        public abstract void Add(int a, int b);
        public abstract void Add(double a, int b);

        public void show()
        {
            Console.WriteLine("Value {0}", add);
        }
    }

    public abstract class Child : Abst
    {
        public override void Add(double p1, int p2)
        {
            base.add = (int)(p1 + p2);
        }

    }
    public class Grand : Child
    {
        public override void Add(int p1, int p2)
        {
            base.add = (p1 + p2);
        }
    }
    public class BaseOne : Abst
    {
        public override void Add(int p1, int p2)
        {
            base.add = (p1 + 10 + p2);
        }
        public override void Add(double p1, int p2)
        {
            base.add = (int)(p1 + 100 + p2);
        }
    }


}
