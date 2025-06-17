using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQDemoObject2
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{Id} \t {Name} \t {Quantity} \t {Price}"
            ;
        }
        //Sao chep du lieu tu o nho nay sang o nho khac
        public Product clone()
        {
            return MemberwiseClone() as Product;
        }

    }
}
