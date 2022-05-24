using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class countduplicate
    {
        static void Main(string []args)
        {
            int[] a = new int[] { 1, 2, 2, 3, 3,4,4 };

            int count = 0;
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]==a[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("number of dublicate element is : " + count);
        }

    }
}

