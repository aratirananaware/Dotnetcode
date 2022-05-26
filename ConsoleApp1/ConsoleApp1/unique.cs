using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class unique
    {
        static void Main1(string[] args)
        {
            int[] a = new int[] { 1, 3, 2, 3,4 };
            int[] b = new int[a.Length];
            int n = a.Length;
            int c = 0;
           for(int i=0;i<n;i++)
            {
                c = 0;
                for(int j=0;j<i-1;j++)
                {
                    if(a[i]==a[j])
                    {
                        c++;
                    }
                }
                for (int k = i + 1; k < n; k++)
                {
                    if (a[i] == a[k])
                    {
                        c++;
                    }

                    if (a[i] == a[i + 1])
                    {
                        i++;
                    }
                }
                if (c == 0)
                    Console.WriteLine(a[i]);
            }
           
            
            
        }
    }
}
