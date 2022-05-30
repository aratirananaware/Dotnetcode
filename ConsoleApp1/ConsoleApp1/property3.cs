using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class property3
    {
        private double radius;
        private double pi = 3.14;

        public property3(double radius1 )
        {
            radius = radius1;
        }
        
        public double getradius
        {
            get{
                return radius;
            }
            
        }
        
      
        public void circmference()
        {
            double res = 2 * radius * pi;
            Console.WriteLine(res);
        }
    }
    class Test
    {
        static void Main1(string []args)
        {
            property3 p = new property3(2.5);
            Console.WriteLine("radius " + p.getradius);
            p.circmference();


        }
    }
}
