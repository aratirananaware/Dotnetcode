using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Generics1
    {
        /*
        public bool compare(int a,int b)
        {
            if(a==b)
            {
                return true;
            }
            return false;
        }
        */
        public bool compare<T>(T a, T b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            return false;
        }
        static void Main1(string[] args)
        {
            Generics1 obj = new Generics1();
            bool res=obj.compare<string>("arati", "arati");
            Console.WriteLine(res);

        }
    }
}
