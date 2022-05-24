using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            char [] t=s.ToCharArray();


            
            Array.Reverse(t);
           string rev = new string(t);
            bool flag = false;
            if(s.Equals(rev))
            {
                flag = true;
            }
            
            
            

            
            if(flag)
            {
                Console.WriteLine("string is palindrome : " + s);
            }
            else
            {
                Console.WriteLine("string is not palindrome");
            }
        }
    }
}
