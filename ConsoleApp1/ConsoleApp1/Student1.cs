using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student1
    {
        public string sname;
        public int sid;
        public string classname;
        public string collegename;

        public Student1()
        {
            collegename = "s.v.p.m";
        }
        public void Getdata()
        {
            Console.WriteLine("Enter student name ");
            sname = Console.ReadLine();
            Console.WriteLine("Enter student id ");
            sid =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter student classname ");
            classname = Console.ReadLine();

        }
        public void printdata()
        {
            Console.WriteLine("student name "+sname);
            Console.WriteLine("student id "+sid);
            Console.WriteLine("student classname "+classname);
            Console.WriteLine("student collegename " + collegename);
        }
        static void Main1(string []args)
        {
            Student1[] studentlist = new Student1[3];
            for(int i=0;i<studentlist.Length;i++)
            {
                Student1 s = new Student1();
                s.Getdata();
                studentlist[i] = s;
            }

            for (int i = 0; i < studentlist.Length; i++)
            {
                studentlist[i].printdata();
            }

        }
    }
}
