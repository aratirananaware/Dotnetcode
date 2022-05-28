using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Constrtype
    {
        public int a;

        public Constrtype()
        {

        }
       public Constrtype(Constrtype c)
        {
            a = c.a;
            Console.WriteLine(a);
        }
        void setvalue()
        {
            a = 2; ;
        }
        /*
        void printvalue()
        {
            Console.WriteLine(a);
        }
        */
        static void Main1(string []args)
        {
            Constrtype s = new Constrtype();
            s.setvalue();
            Constrtype s1 = new Constrtype(s);
           // s1.printvalue();

        }
    }
}
