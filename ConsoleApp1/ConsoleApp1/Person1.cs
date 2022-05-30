using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person1
    {
        public string Name;

        public Person1(string name)
            {
            Name = name;
            }
        ~Person1()
        {
            Name = "";
        }
        public override string ToString()
        {

            return Name;
        }
        static void Main(string[] args)
        {
            Person1 p1 = new Person1("arati");
            Person1 p2 = new Person1("dipa");
            Person1 p3 = new Person1("ashwini");
            Person1[] person = new Person1[3] { p1, p2, p3 };

            Console.WriteLine("name of person");
            foreach(Person1 p in person)
            {
                Console.WriteLine(p);
            }
        }
    }
}
