using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class staticConstructor
    {
        static staticConstructor()
        {
            Console.WriteLine("i am a static Constructor");
        }
        static void Main(string[] args)
        {
            staticConstructor s = new staticConstructor();

        }
    }
}
