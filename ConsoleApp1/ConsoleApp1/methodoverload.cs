using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class methodoverload
    {
        public static void sum()
        {
            int add = 1 + 2;
            Console.WriteLine("addition is " + add);
        }
        public static void sum(int a,int b)
        {
            int add = a+b;
            Console.WriteLine("addition is " + add);
        }
        public static void sum(int a, int b,int c)
        {
            int add = a + b+c;
            Console.WriteLine("addition is " + add);
        }
        public static void sum(string a,string b)
        {
            int add = Convert.ToInt32(a)+Convert.ToInt32(b);
            Console.WriteLine("addition is " + add);
        }
    }
    class Test2
    {
        static void Main1(string[] args)
        {
            methodoverload.sum();
            methodoverload.sum(1, 2);
            methodoverload.sum("1", "2");
            methodoverload.sum(1, 2, 3);
        }
    }
}
