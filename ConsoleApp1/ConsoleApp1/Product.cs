using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Product
    {
        public string ProductCode,Name,Brand;
        public double Price;

        public Product() { }
        public Product(string prodcode,string name,double price,string brand)
        {
            ProductCode = prodcode;
            Name = name;
            Price = price;
            Brand = brand;

        }
    }
    class Shop
    {
        string Name;
        List<Product> Prodlist = new List<Product>();
        
        public Shop() { }
            public Shop(string name,List<Product> prodctlist)
        {
            Name = name;
            Prodlist = prodctlist;
        }

        public void AddproductToShop(Product p)
        {
            int flag = 0;
            foreach (var str in Prodlist)
            {
                if (str.ProductCode == p.ProductCode && str.Name == p.Name)
                {
                    flag = 1;
                }
            }
            if (flag == 0)
                Prodlist.Add(p);
        }

        public bool RemoveProductFromShop(string productCode)
        {
            foreach (var str in Prodlist)
            {
                if (str.ProductCode == productCode)
                {
                    Prodlist.Remove(str);
                    return true;
                }
            }
            return false;
        }
    }

    class ProductBO
    {
        public List<Product> FindProduct(List<Product> prodlist, string brand)
        {
            List<Product> prod4 = new List<Product>();
            foreach (var str in prodlist)
            {
                if (str.Brand == brand)
                    prod4.Add(str);
            }
            return prod4;
        }
        public List<Product> FindProduct(List<Product> prodlist, double price)
        {
            List<Product> prod2 = new List<Product>();
            foreach (var str in prodlist)
            {
                if (str.Price == price)
                    prod2.Add(str);
            }
            return prod2;
        }
        public Hashtable BrandWiseCount(List<Product> productList)
        {
            Hashtable ht = new Hashtable();
            var res = from p in productList
                      group p by p.Brand into brand
                      select new { Brand = brand.Key, Cnt = brand.Count() };
            foreach (var x in res)
            {
                ht.Add(x.Brand, x.Cnt);
            }
            return ht;
        }
    }
}
