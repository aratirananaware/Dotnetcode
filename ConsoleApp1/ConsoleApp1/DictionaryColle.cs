using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DictionaryColle
    {
        static void Main1(string []args)
        {
            Dictionary<string, object> dt = new Dictionary<string, object>();
            dt.Add("id", 12);
            dt.Add("name", "arati");

            foreach(string key in dt.Keys)
            {
                Console.WriteLine(key+" "+dt[key]);
            }
            
        }
    }
}
