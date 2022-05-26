using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class generic3<T>
    {
        public void Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
    }
    class Testgenerics
    { 
        static void Main1(string[] args)
        {
            generic3<int> g = new generic3<int>();
            g.Add(1, 8);

        }
    }
}
