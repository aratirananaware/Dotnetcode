using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class generic2
    {
        public void Add<T>(T a,T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void sub<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        static void Main1(string []args)
        {
            generic2 g = new generic2();
            g.Add<int>(1, 8);

        }
    }
}
