using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
   public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Address { get; set; }
    }
    public class PersonImplementation
    {
        public double Average(IList<Person> Person)
        {
            double avg = Person.Average(x => x.Age);
            return avg;
        }
        public int Max(IList<Person> Person)
        {
            int max = Person.Max(x => x.Age);
            return max;
        }
    }
    class Test
    {
        static void Main1(string[] args)
        {
            IList<Person> person = new List<Person>();
            person.Add(new Person { Name = "arati", Age = 22, Address = "pune" });
            person.Add(new Person { Name = "pooja", Age = 23, Address = "mumbai" });
            PersonImplementation p = new PersonImplementation();
           Console.WriteLine("Average "+p.Average(person));
            Console.WriteLine("Max "+p.Max(person));

        }
    }
}
