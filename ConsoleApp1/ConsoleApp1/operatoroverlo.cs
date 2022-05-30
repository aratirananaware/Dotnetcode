using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class operatoroverlo
    {
       public int number1;
       public int number2;

        public operatoroverlo(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }

        public void print()
        {
            Console.WriteLine("Number1 : " + number1);
            Console.WriteLine("Number2 : " + number2);

        }

        public static operatoroverlo operator +(operatoroverlo p, operatoroverlo p1)
            {
            operatoroverlo p3 = new operatoroverlo(0, 0);
            p3.number1 = p.number1 + p1.number1;
            p3.number2 = p.number2 + p1.number2;
            return p3;
            }
        static void Main1(string[] args)
        {
            operatoroverlo p = new operatoroverlo(10, 20);
            operatoroverlo p1 = new operatoroverlo(20, 30);
            operatoroverlo p3 = new operatoroverlo(0, 0);
            p3 = p + p1;
            p3.print();


        }
    }
}
