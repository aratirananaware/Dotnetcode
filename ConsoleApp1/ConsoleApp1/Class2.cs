using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class2
    {
        static void Main4(string[] args)
        {
            /*
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i >= j)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            

            for(int i=0;i<9;i++)
            {
                for(int j=0;j<8;j++)
                {
                    if ((i == 0 || j == 0|| j==7 || i==8) || (i==j) || i+j==8 )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            */

            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i > j)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }

                for(int k=0;k<5;k++)
                {
                    for (int l = 0; l < 5; l++)
                    {
                        if (k >= l)
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }
                

            
            
        }

    }
}

