using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Arrayuniqelement
    {
        static void Main1(string []args)
        {
            int[] a = new int[6] {1,2,3,4,4,5};
            int[] b = new int[a.Length];
            int c = 0;
            
            
            for(int i=0;i<a.Length;i++)
            {
                int flag = 0;
                   for(int j=0;j<i;j++)
                {
                    if(a[i]==a[j])
                    {
                        flag = 1;
                        break;
                    }
                }
                    if(flag==0)
                    {
                        b[c] = a[i];
                    c++;
                    }
                
                 

            }
           
            
            for(int j=0;j<c;j++)
            {
                Console.WriteLine(b[j]);
            }
        }
    }
}
