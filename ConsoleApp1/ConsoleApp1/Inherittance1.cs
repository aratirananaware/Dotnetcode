using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class shape
    {
        protected int length;
        protected int width;

    }
    class square:shape
    {
        public square(int side)
        {
            length = width = side;
        }
        public void area()
        {
            Console.WriteLine("area of square : " + (length * width));
        }
    }
    class rectangle:shape
    {
        public rectangle(int l,int w)
        {
            length = l;
            width = w;
        }
      public  void area()
        {
            Console.WriteLine("area of rectangle : " + (length * width));
        }
    }
    class Inherittance1
    {
        static void Main1(string[] args)
        {
            square s = new square(2);
            s.area();
            rectangle r = new rectangle(4,2);
            r.area();


            
        }

    }
}
