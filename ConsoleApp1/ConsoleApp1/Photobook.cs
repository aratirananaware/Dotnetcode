using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Photobook
    {
        private int numPages;
        
        public void setnum(int num)
        {
            numPages = num;
        }
       
        public Photobook()
        {
            numPages = 16;
        }
        public Photobook(int numpageswewant)
        {
            numPages = numpageswewant;
        }
            public int getNumberPages()
        {
            return numPages;
        }
    }

    class Bigphotobook:Photobook
    {
        int numPages; 
        public Bigphotobook(int num)
        {
            numPages = num;
        }

    }

    class Test1
    {
        static void Main1(string[] args)
        {
            Photobook p1 = new Photobook();
            Console.WriteLine("number of pages : " + p1.getNumberPages());
            Photobook p2 = new Photobook(24);
           Console.WriteLine("number of pages : "+p2.getNumberPages());
            Bigphotobook b1 = new Bigphotobook(64);
            b1.setnum(64);
            Console.WriteLine("number of pages : " + b1.getNumberPages());





        }
    }
}
