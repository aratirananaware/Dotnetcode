using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp1
{
    class Student:IComparable<Student>
    {
        public int sid { get; set; }
        public string name { get; set; }
        public int mark { get; set; }

        public int CompareTo( Student other)
        {
            if (this.sid > other.sid)
                return 1;
            else if (this.sid < other.sid)
                return -1;
            else
                return 0;
           
        }
    }
    class CompareStudents : IComparer<Student>
    {
        public int Compare( Student x,  Student y)
        {
            if (x.mark > y.mark)
                return 1;
            else if (x.mark < y.mark)
                return -1;
            return 0;
        }
    }
    class TestStudent
    {
        public static int CompareName(Student s1,Student s2)
        {
            return s1.name.CompareTo(s2.name);
        }
        static void Main1(string []args)
        {
            Student s1 = new Student { sid = 11, name = "riya", mark = 89 };
            Student s2 = new Student { sid = 2, name = "hina", mark = 77 };
            Student s3 = new Student { sid = 4, name = "jiva", mark = 67 };

            List<Student> list = new List<Student>();
            list.Add(s1);
            list.Add(s2);
            list.Add(s3);
            // list.Sort();

            //CompareStudents obj = new CompareStudents();
            //  list.Sort(obj);
            Comparison<Student> obj = new Comparison<Student>(CompareName);
            list.Sort(obj);
            foreach(Student s in list)
            {
                Console.WriteLine(s.sid + " " + s.name + " " + s.mark);
            }


        }
    }
}
