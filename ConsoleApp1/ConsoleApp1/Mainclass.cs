using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class person
    {
       protected int age;
        public void Greet()
        {
            Console.WriteLine("Say hello ");
        }
        public void setAge(int age1)
        {
            age = age1;
        }
    }
    class student:person
    {
        public void study()
        {
            Console.WriteLine("i am studying on screen ");

        }
        public void showAge()
        {
            Console.WriteLine("My age is: "+age+" years old on the screen.");
        }
    }
    class teacher:person
    {
        public void Explain()
        {
            Console.WriteLine("i am explaining on screen ");
        }
        public void showAge()
        {
            Console.WriteLine("My age is: " + age);
        }
    }
    class Mainclass
    {
        static void Main1(string[] args)
        {
            person p = new person();
            p.Greet();
            student s = new student();
            s.setAge(20);
            s.Greet();
            s.showAge();
            teacher t = new teacher();
            t.Greet();
            t.setAge(40);
            t.showAge();
            t.Explain();
        }
    }
}
