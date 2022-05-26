using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1
{
    class HashCollection
    {
        static void Main1(string []args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid", 11);
            ht.Add("ename", "arati");

            foreach(Object key in ht.Keys)
            {
                Console.WriteLine(key+" "+ht[key]);
            }



        }
    }
}
