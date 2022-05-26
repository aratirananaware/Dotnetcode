using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class GenericList
    {
        static void Main1(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(10);
            li.Add(20);
            li.Insert(1, 35);
            foreach(int i in li)
            {
                Console.WriteLine(i);
            }
        }
    }
}
