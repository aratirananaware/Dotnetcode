using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{

   

    class Program1
    {

        public string SENTINEL = "~";
        public string PadLeft(string input, int n, char a)
        {
            string pad1 = input.PadLeft(n, a);
            return pad1;
        }

        public string JoinIt(string[] input)
        {
            string joint = string.Join(SENTINEL, input);
            return joint;
        }

        public string[] SplitIt(string input)
        {
            string[] split = input.Split(Convert.ToChar(SENTINEL));
            return split;
        }

        public StringBuilder Reverse(string input)
        {
            string[] arr = input.Split(' ');
            StringBuilder rev = new StringBuilder();
            int L = arr.Length;
            for (int i = L - 1; i >= 0; i--)
            {
                rev.Append(arr[i] + " ");
            }
            return rev;
        }
    }

    class Test22
    {
        static void Main1(string[] args)
        {
            Program1 p = new Program1();
            string[] a = new string[] { "one", "two" };
           Console.WriteLine("join "+p.JoinIt(a));
            string[] a1 = new string[4];
            /*
            for(int i=0;i<a1.Length;i++)
            {
                a1[i] =Convert.ToString( p.SplitIt("one~two"));
            }
            for (int i = 0; i < a1.Length; i++)
            {
                Console.WriteLine(a1[i]);
            }
            */
            Console.WriteLine("reverse " + p.Reverse("seven two three"));
            Console.WriteLine("padleft " + p.PadLeft("OneTwoThree", 15, '~'));

        }
    }
}
