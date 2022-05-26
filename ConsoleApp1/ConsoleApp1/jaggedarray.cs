using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class jaggedarray
    {
        static void Main1(string []args)
        {
            int[][] a = new int[2][];
            a[0]=new int[] { 1, 2 };
            a[1]=new int[] { 1, 2, 3 };

            for(int i=0;i<a.Length;i++)
            {
                for(int j=0;j<a[i].Length;j++)
                {
                    Console.Write(a[i][j] + "\t");
                }
                Console.WriteLine();

            }
        }
    }
}
