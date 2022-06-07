using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ConsoleApp3.Models;


namespace ConsoleApp3
{
    class Calculator
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the choice");
                Console.WriteLine("1.Add Record");
                Console.WriteLine("2.List Record");
                Console.WriteLine("3.Update Record");
                Console.WriteLine("4.Delete Record");
                Console.WriteLine("5.Exit");


                int ch = Convert.ToInt32(Console.ReadLine());
                sampledbContext db = new sampledbContext();
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter your name");
                         string name=Console.ReadLine();
                       Tblsample tblsample = new Tblsample();
                         tblsample.Text=name;
                          db.Tblsamples.Add(tblsample);
                             db.SaveChanges();
                        break;
                    case 2:
                        var data = db.Tblsamples;

                        Console.WriteLine("record----");
                        foreach (var item in data)
                        {
                            Console.WriteLine(item.Text + " | " + item.Id);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Pleae enter id of your name which you want to update");
                        int InsertItem = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the new name");
                        var newName = Console.ReadLine();
                        var UpdatteObject = db.Tblsamples.Where(x => x.Id == InsertItem).FirstOrDefault();
                        UpdatteObject.Text = newName;
                        db.Tblsamples.Update(UpdatteObject);
                        db.SaveChanges();
                        break;
                    case 4:
                        Console.WriteLine("Pleae enter id of your name which you want to delete");
                        int DeleteItem = Convert.ToInt32(Console.ReadLine());
                        var DeleteObject = db.Tblsamples.Where(x => x.Id == DeleteItem).FirstOrDefault();
                        db.Tblsamples.Remove(DeleteObject);
                        db.SaveChanges();
                        break;
                    case 5:Environment.Exit(0);
                        break;
                    default:Console.WriteLine("invalid choice");
                        break;

                }
            }
        }
    }
}
