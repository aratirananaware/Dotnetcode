using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class program123
    {
        public static void Main(string[] args)
        {
            string str1;
            string findstr;
            str1 = Console.ReadLine();

            findstr = Console.ReadLine();

            int index = str1.IndexOf(findstr);

            if(index<0)
            {
                Console.WriteLine("found'cap' in the 'capgemini' at position\n");
            }
            else
            {
                Console.WriteLine("found'{0}' in '{1}' at position {2}", findstr, str1, index);
            }
        }
    }
}
