using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class varvsdynamic
    {
        static void Main1(string []args)
        {
            var x = 1;
           // x="jiya"        // it will give error if want save string in x
            Console.WriteLine("x : " + x);
            dynamic y = "arati";
            y = 2;           //but in dynamic will not give error if we set another type value
            Console.WriteLine("y : " + y);
        }
    }
}
