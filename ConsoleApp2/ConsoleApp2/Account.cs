using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Account
    {
        private string Name;
        private double balance;

       public Account(string name,double balance)
        {
            this.Name = name;
            if (balance > 0.0)
            {
                this.balance = balance;
            }
        }

        public double deposit(double depositamount)
        {
            if(depositamount>0.0)
            {
                balance = balance + depositamount;
            }
            return balance;
        }
        public double getBalance()
        {
            return this.balance;
        }
        public string getName()
        {
            return this.Name;
        }

        public void setName(string name)
        {
            this.Name = name;
        }

    }
    class Test1
    {
        static void Main1(string[] args)
        {
            Account a = new Account("joseph", 250.00);
            Console.WriteLine("balance "+a.getBalance());
        }
    }
}
