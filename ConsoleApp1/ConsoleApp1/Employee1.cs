using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Employee1
    {
        int Eid;
        string Ename;
        int salary;
        string gender;

        
        static void Main1(string [] args)
        {
            Employee1 e = new Employee1();
            Console.WriteLine(e.Eid = 1);
            Console.WriteLine(e.Ename = "arati");
            Console.WriteLine(e.gender = "female");
            Console.WriteLine(e.salary = 22000);
        }
    }
}
