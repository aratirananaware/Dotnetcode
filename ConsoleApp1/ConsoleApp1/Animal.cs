using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Animal
    {
        public string Name;

        public void setName(string name1)
        {
            Name = name1;
        }
        public string getName()
        {
            return Name;
        }
        public abstract void eat();
        
    }
    class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("dog is eating");
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("enter the dog name");
            string name = Console.ReadLine();
            Dog d = new Dog();
            d.setName(name);
            Console.WriteLine("Name of dog is : "+d.getName());
            d.eat();
        }
    }
}
