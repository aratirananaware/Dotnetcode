using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeApp
{
    class Program
    {
        static void Main1(string[] args)
        {
            ICake cup = new CupCake();
            ICake pinata = new PinataCake();
            var res1 = cup.getPrice("Vanilla", 2, 0.5);
            var res2 = pinata.getPrice("Chocolate", 2, 0.5);
            Console.WriteLine("" + res1);
            Console.WriteLine("" + res2);
        }
    }


    public interface ICake
    {
        public double getPrice(string Flavour, int toppings, double sizeinkg);

    }

    public class CupCake : ICake
    {
        double pricekg;
        public double getPrice(string Flavour, int toppings, double sizeinkg)
        {

            if (Flavour == "Vanilla")
            {
                pricekg = 100 + (toppings * 15);
                return pricekg * sizeinkg;
            }
            else
            {
                pricekg = 150 + (toppings * 15);
                return pricekg * sizeinkg;
            }
        }
    }

    public class PinataCake : ICake
    {
        double pricekg;
        public double getPrice(string Flavour, int toppings, double sizeinkg)
        {

            if (Flavour == "Vanilla")
            {
                pricekg = 250 + (toppings * 40);
                return (pricekg * sizeinkg) + 100;
            }
            else
            {
                pricekg = 350 + (toppings * 40);
                return (pricekg * sizeinkg) + 100;
            }
        }

    }
}
