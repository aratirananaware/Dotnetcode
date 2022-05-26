using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class factorial
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("enter the number ");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = fact(n);
            Console.WriteLine("Factorial is : " + result);

        }

        static int fact(int number)
        {
            int sum = 1;
            for(int i=number;i>=1;i--)
            {
                sum = sum * i;
            }
            return sum;
        }
    }
}
