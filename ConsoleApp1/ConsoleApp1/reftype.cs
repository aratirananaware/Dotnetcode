using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class reftype
    {
        static void Main1(string[] args)
        {
            int x = 5, y = 6;
            reftype s = new reftype();
            swap(ref x, ref y);
            Console.WriteLine(" swapping in main method : " + x + "  " + y);

            int result, result1, result2, result3;
            x1(10, out result);
            Console.WriteLine(" result is " + result);
            x3(out result1, out result2, out result3);
            Console.WriteLine("results     " + result1 + " " + result2 + "  " + result3);

        }

        static void swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("swaping " + a + " " + b);
        }
        static void x1(int n, out int s)
        {
            s = n + 1;
        }
        static void x3(out int s1, out int s2, out int s3)
        {
           s1=1;
            s2=2;
            s3=3;
        }
}
}
