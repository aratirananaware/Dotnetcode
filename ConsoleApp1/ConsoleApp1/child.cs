using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Base
    {
        public virtual void show()
        {
            Console.WriteLine("i am in base class");
        }
    }
    class child:Base
    {
        public  override void show()
        {
            Console.WriteLine("i am in child class");
        }

        static void Main1(string[] args)
        {
            child c = new child();
            c.show();
            Base b = new child();
            b.show();
        }
    }
}
