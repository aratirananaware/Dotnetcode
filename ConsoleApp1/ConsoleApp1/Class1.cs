using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main1(string[] args)
        {
            /*
            Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());

            switch(a)
            {
                case 1:Console.WriteLine("Monday");
                    break;
                case 2:Console.WriteLine("Tuesday");
                    break;
                case 3:Console.WriteLine("wednesday");
                    break;
                case 4:Console.WriteLine("thursday");
                    break;
                case 5:Console.WriteLine("friday");
                    break;
                case 6:Console.WriteLine("saturday");
                    break;
                case 7:Console.WriteLine("sunday");
                    break;
                default:Console.WriteLine("invalid choice");
                    break;

            }
            */


            Console.WriteLine("Enter your choice");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Mltiplication");
            Console.WriteLine("4.Divide");

            int ch = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            switch(ch)
            {
                case 1:Console.WriteLine("Addition is : "+(a + b));
                    break;
                case 2:Console.WriteLine("Substraction is : "+(a - b));
                    break;
                case 3:Console.WriteLine("Multiplication is : "+(a * b));
                    break;
                case 4:Console.WriteLine("Dividation is : "+(a / b));
                    break;
                default:Console.WriteLine("invalid choice");
                    break;

            }
        }
    }
}
