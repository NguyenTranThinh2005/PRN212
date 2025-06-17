using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }
        public Category()
        {
            Products = new Dictionary<int, Product>();

        }
        /*Mọi dữ liệu cần làm đủ: CRUD
         */
        public void AddProduct(Product p)
        {
            if (Products.ContainsKey(p.Id))
            {
                return;  
            }
            Products.Add(p.Id, p);
        }
            //Xem toan bo product
            public void PrintAllProduct()
            {
            foreach(KeyValuePair<int, Product> item in Products)
            {
                Product p = item.Value;
                Console.WriteLine(p);
            }
            }
        //Loc ra san pham co gia tu x toi y
        public Dictionary<int,Product> FilterProductByPrice(double min,double max)
        {
            Dictionary<int,Product> result = new Dictionary<int,Product>();
            result = Products.Where(item => item.Value.Price >=min && item.Value.Price <= max).ToDictionary<int,Product>();
            return result;
        }
        //Sap xep san pham theo gia tang dan
        public Dictionary<int, Product> SortProductByPriceAsc()
        {
            return Products.OrderBy(item => item.Value.Price).ToDictionary<int,Product>();
        }
        //Neu trung gia, sap xep theo so luong giam dan
        public Dictionary<int, Product> SortComplexProduct()
        {
            return Products.OrderBy(item => item.Value.Price).OrderByDescending(item=> item.Value.Quantity).ToDictionary<int, Product>();
        }
        public bool updateProduct(Product p)
        {
            if(p==null || Products.ContainsKey(p.Id)==false) return false;
            Products[p.Id] = p;//de du lieu moi vao o nho hien tai hoac tham chieu toi o nho khac
            return true;
        }
        public bool removeProduct(int id)
        {
            if (Products.ContainsKey(id) == false) return false;
            return Products.Remove(id);
        }

    }
}
