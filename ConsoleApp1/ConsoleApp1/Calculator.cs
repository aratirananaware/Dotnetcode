using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Calculator
    {
        public int number1;
        public int number2;

        public Calculator(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public void print()
        {
            Console.WriteLine("number1 " + number1);
            Console.WriteLine("number2 " + number2);
        }
        public static Calculator operator *(Calculator c1, Calculator c2)
        {
            Calculator c3 = new Calculator(1, 1);
            c3.number1 = c1.number1 * c2.number1;
            c3.number2 = c1.number2 * c2.number2;

            return c3;

        }
        static void Main1(string[] args)
        {
            Calculator c1 = new Calculator(2, 2);
            Calculator c2 = new Calculator(3, 3);
            Calculator c3 = new Calculator(1, 1);
            c3 = c1 * c2;
            c3.print();
        }
    }
}

