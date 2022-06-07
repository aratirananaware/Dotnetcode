using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{ 
class Activity
{
    public string String1;
    public string String2;
    public char Operator;
    public Activity(string str1, string str2, char op)
    {
        String1 = str1;
        String2 = str2;
        Operator = op;
    }
}
class Source
{
    string result, msg;
    public string HandleException(Activity a)
    {
        try
        {
            if (String.IsNullOrWhiteSpace(a.String1) ||
           String.IsNullOrWhiteSpace(a.String2))
            {
                throw new ArgumentNullException("Null values found");
            }
            else if (a.Operator != '+' && a.Operator != '-')
            {
                throw new Exception($"{ a.Operator }");
            }
            else
            {
                msg = "No Exception Found";

            }

        }
        catch (ArgumentNullException e)
        {
            msg = e.Message;

        }
        catch (Exception e)
        {
            msg = e.Message;
        }
        return msg;
    }
    public string Operate(Activity a)
    {
        char choice = a.Operator;
        switch (choice)
        {
            case '+':
                result = a.String1 + a.String2;
                break;
            case '-':
                result = a.String1.Replace(a.String2, "");
                break;
        }
        return result;
    }
    static void Main1(string[] args)
    {
        Activity a = new Activity("hello", "world", '+');
        Source s = new Source();
        string emsg = s.HandleException(a);
        Console.WriteLine(emsg);
        if (emsg == "No Exception Found")
        {
            string toprint = s.Operate(a);
            Console.WriteLine(toprint);
        }
        Console.Read();
    }
}
}
