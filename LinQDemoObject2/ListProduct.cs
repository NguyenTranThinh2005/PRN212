using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQDemoObject2
{
    public class ListProduct
    {
        List<Product> products;
        public ListProduct()
        {
            products = new List<Product>();
        }
        public void create_Product()
        {
            products.Add(new Product() { Id = 1, Name = "Sp11", Quantity = 10, Price = 20 });
            products.Add(new Product() { Id = 2, Name = "Sp12", Quantity = 20, Price = 30 });
            products.Add(new Product() { Id = 3, Name = "Sp13", Quantity = 30, Price = 205 });
            products.Add(new Product() { Id = 4, Name = "Sp14", Quantity = 40, Price = 20 });
            products.Add(new Product() { Id = 5, Name = "Sp15", Quantity = 50, Price = 202 });
            products.Add(new Product() { Id = 6, Name = "Sp16", Quantity = 160, Price = 220 });
            products.Add(new Product() { Id = 7, Name = "Sp17", Quantity = 17, Price = 230 });
            products.Add(new Product() { Id = 8, Name = "Sp18", Quantity = 80, Price = 250 });
            products.Add(new Product() { Id = 9, Name = "Sp19", Quantity = 90, Price = 210 });
            products.Add(new Product() { Id = 10, Name = "Sp10", Quantity = 20, Price = 120 });
            products.Add(new Product() { Id = 11, Name = "Sp111", Quantity = 15, Price = 720 });
            products.Add(new Product() { Id = 12, Name = "Sp12", Quantity = 14, Price = 60 });
        }
        public List<Product> FilterByPrice(double price1, double price2)
        {
            return products.Where(p=>p.Price > price1 &&p.Price< price2).ToList();
        }
        public List<Product> FilterByPrice2(double price1, double price2)
        {
            var result = from p in products
                         where p.Price > price1 && p.Price < price2
                         select p;
            return result.ToList();
        }

        public List<Product> SortPriceDesc()
        {
            return products.OrderByDescending(p=>p.Price).ToList();
        }
        public List<Product> SortPriceDesc2()
        {
            var result = from p in products
                         orderby p.Price descending
                         select p;
            return result.ToList();
        }
        public double sumValue()
        {
            return products.Sum(p=>p.Quantity*p.Price);
        }
    }
}
