using System;
using ConsoleApp3.Models;
using System.Linq;
namespace ConsoleApp3
{
    class Program
    {
        
        static void Main1(string[] args)
        {
            


            //Console.WriteLine("Enter your name");
           // string name=Console.ReadLine();
                sampledbContext db = new sampledbContext();
            /*
            Tblsample tblsample = new Tblsample();
           //tblsample.Text = "arati";
           tblsample.Text=name;
            db.Tblsamples.Add(tblsample);
            db.SaveChanges();
            */
            var data = db.Tblsamples;
            
            Console.WriteLine("record----");
            foreach(var item in data)
            {
                Console.WriteLine(item.Text + " | " + item.Id);
            }


            //How we can delete the value
            /*
            Console.WriteLine("Pleae enter id of your name which you want to delete");
            int DeleteItem = Convert.ToInt32(Console.ReadLine());
            var DeleteObject = db.Tblsamples.Where(x => x.Id == DeleteItem).FirstOrDefault();
            db.Tblsamples.Remove(DeleteObject);
            db.SaveChanges();

            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.Text);
            }
            */
            //How we can Update the value
            
            Console.WriteLine("Pleae enter id of your name which you want to update");
            int InsertItem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the new name");
            var newName = Console.ReadLine();
            var UpdatteObject = db.Tblsamples.Where(x => x.Id == InsertItem).FirstOrDefault();
            UpdatteObject.Text = newName;
            db.Tblsamples.Update(UpdatteObject);
            db.SaveChanges();

            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.Text);
            }

            
        }
    }
}
