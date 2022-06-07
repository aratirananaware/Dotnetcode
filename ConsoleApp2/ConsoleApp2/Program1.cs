using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentApp
{
    class Program
    {
        static void Main1(string[] args)
        {
            Appointment obj = new Appointment("Tuesday", 15);
            var res = obj.CheckSlot();
            Console.WriteLine(res);
        }
    }


    public class Appointment
    {
        string Day;
        int Time;

        public Appointment(string Day, int Time)
        {
            this.Day = Day;
            this.Time = Time;
        }

        int strtime;
        int endtime;

        public string CheckSlot()
        {
            if (Day != "Saturday" && Day != "Sunday")
            {
                switch (Day)
                {
                    case "Monday":
                        strtime = 6;
                        endtime = 18;
                        break;
                    case "Tuesday":
                        strtime = 6;
                        endtime = 16;
                        break;
                    case "Wednesday":
                        strtime = 6;
                        endtime = 14;
                        break;
                    case "Thursday":
                        strtime = 6;
                        endtime = 12;
                        break;
                    case "Friday":
                        strtime = 6;
                        endtime = 10;
                        break;
                }
                if (Time >= strtime && Time < endtime)
                    return "Available";
                else return "Not Available";
            }
            else return "Not Available";
        }

        private Dictionary<string, int> GetTimeSlots()
        {
            Dictionary<string, int> a = new Dictionary<string, int>();
            a.Add("a", 1);
            return a;
        }
    }
}
