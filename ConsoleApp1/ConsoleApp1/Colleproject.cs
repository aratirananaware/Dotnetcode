using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Customer
    {
        public int custid { get; set; }
        public string name { get; set; }


    }
    class Testcustomer
    {
        static void Main1(string[] args)
        {
            List<Customer> cust = new List<Customer>();
            Customer c1 = new Customer { custid = 111, name = "arati" };
            Customer c2 = new Customer { custid = 121, name = "pooja" };

            cust.Add(c1);
            cust.Add(c2);

            foreach(Customer c in cust)
            {
                Console.WriteLine(c.custid + " " + c.name);
            }
        }
    }
}
