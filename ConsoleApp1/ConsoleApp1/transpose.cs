using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class transpose
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("enter matrix element row " + i + "col " + j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

           
            Console.WriteLine("---------transpose of matrix--------");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(a[j,i]+"\t");

                }
                Console.WriteLine();
            }
        }
        }
}
