using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }


    }
    public class Organization:IEnumerable
    {
        List<Employee> Emps = new List<Employee>();
        public void Add(Employee Emp)
        {
            Emps.Add(Emp);
        }
        public int count
        {
            get { return Emps.Count; }

        }
        public Employee this[int index]
        {
            get
            {
                return Emps[index];
            }
        }
        public IEnumerator GetEnumerator()
        {
            // return Emps.GetEnumerator();

            return new OrganizationEnumerator(this);
        }
    }
    public class OrganizationEnumerator : IEnumerator
    {
        Organization orgColl;
        int CurrentIndex;
        Employee CurrentEmployee;

        public OrganizationEnumerator(Organization org)
        {
            orgColl = org;
            CurrentIndex = -1;
            
        }
        public object Current
        {
            get
            {
                return CurrentEmployee;
            }
        }

        public bool MoveNext()
        {
           if(++CurrentIndex >=orgColl.count)
            {
                return false;
            }
            else
            {
                CurrentEmployee = orgColl[CurrentIndex];
            }
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
    class TestEmployee
    {
        static void Main1(string[] args)
        {
            //List<Employee> emp = new List<Employee>();
            Organization emp = new Organization();

            emp.Add(new Employee { id = 134, name = "gita", salary = 30000 });
            emp.Add(new Employee { id = 189, name = "arati", salary = 22000 });

            foreach(Employee emp1 in emp)
            {
                Console.WriteLine(emp1.id + " " + emp1.name + " " + emp1.salary);
            }


        }
    }
}
