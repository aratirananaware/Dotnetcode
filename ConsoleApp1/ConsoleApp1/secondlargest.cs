using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class secondlargest
    {
        static void Main6(string[] args)
        {
            Console.WriteLine("enter the size of array");
                int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("enter the array element : ");
            for(int i=0;i<n;i++)
            {
               a[i]=Convert.ToInt32( Console.ReadLine());
            }
            int temp;
            for(int i=0;i<n;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if(a[i]>a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("second largest number : " + a[n - 2]);

        }
            
    }
}
