using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class arrayaddition
    {
        static void Main1(string[] args)
        {
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
           
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.WriteLine("enter the 1 st matrix element row " + i + "col " + j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("enter the 2 nd matrix element row "+i+"col "+j);
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            /*
            Console.WriteLine("----addition of two matrix----")
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    
                    Console.Write(a[i, j] + b[i, j] + "\t");
                }
                Console.WriteLine();
            }
            */
            int[,] c = new int[2, 2];
            Console.WriteLine("----multiplication of two matrix----");
                
            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        c[i,j] += a[i, k] * b[k, j];
                        
                    }
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
