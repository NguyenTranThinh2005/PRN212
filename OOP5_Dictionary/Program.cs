using OOP5_Dictionary;
#region 5 object va 1 category
Category c1 = new Category()
{
    Id = 1,
    Name = "Nuoc ngot"
};
Product p1 = new Product()
{
    Id = 1,
    Name = "Coca",
    Quantity = 12,
    Price = 10.0
};
Product p2 = new Product()
{
    Id = 2,
    Name = "Pepsi",
    Quantity = 19,
    Price = 15.0
};
Product p3 = new Product()
{
    Id = 3,
    Name = "TaiLoc",
    Quantity = 43,
    Price = 17.0
};
Product p4 = new Product()
{
    Id = 4,
    Name = "Monster",
    Quantity = 13,
    Price = 27.0
};
Product p5 = new Product()
{
    Id = 5,
    Name = "C2",
    Quantity = 13,
    Price = 10.0
};
c1.AddProduct(p1);
c1.AddProduct(p2);
c1.AddProduct(p3);
c1.AddProduct(p4);
c1.AddProduct(p5);
#endregion

//Xuat toan vo san pham cua danh muc
Console.WriteLine("--Toan bo san pham--");
c1.PrintAllProduct();

Dictionary<int, Product> filter = c1.FilterProductByPrice(10.0, 20.0);
Console.WriteLine("--San pham co gia tu 10.0 den 20.0");
foreach (KeyValuePair<int, Product> item in filter)
{
    Product p = item.Value;
    Console.WriteLine(p);
}
//Sap xep tang dan
Dictionary<int, Product> sort = c1.SortProductByPriceAsc();
Console.WriteLine("--San pham sau khi sap xep tang dan theo gia--");
foreach (KeyValuePair<int, Product> item in sort)
{
    Product p = item.Value;
    Console.WriteLine(p);
}
//Sap xep dua theo price, quantity
Dictionary<int, Product> sortComplex = c1.SortComplexProduct();
Console.WriteLine("--San pham sau khi sap xep so luong giam dan, gia tang dan neu trung so luong--");
foreach (KeyValuePair<int, Product> item in sortComplex)
{
    Product p = item.Value;
    Console.WriteLine(p);
}
//Cap nhat san pham
p1.Name = "Xa xi";
p1.Price = 50.0;
p1.Quantity = 22;
c1.updateProduct(p1);
Console.WriteLine("San pham sau khi chinh sua");
c1.PrintAllProduct();

int id = 9;
bool del = c1.removeProduct(id);
if (del)
{
    Console.WriteLine("Xoa thanh cong");
}
else
{
    Console.WriteLine($"Khong tim thay san pham id {id} de xoa");
}
Console.WriteLine("Danh sach sau khi xoa:");
c1.PrintAllProduct();
Category c2 = new Category()
{
    Id=2,Name="Bia"
};
c2.AddProduct(new Product() { Id = 6, Name = "Saigon", Quantity = 30, Price = 21.0 });
c2.AddProduct(new Product() { Id = 7, Name = "333", Quantity = 12, Price = 24.0 });
c2.AddProduct(new Product() { Id = 8, Name = "Heniken", Quantity = 34, Price = 26.0 });

LinkedList<Category> ss = new LinkedList<Category>();
ss.AddLast(c1);
ss.AddLast(c2);
Console.WriteLine("--Toan bo du lieu theo danh muc---");
foreach (Category c in ss)
{
    Console.WriteLine($"--{c.Name}--");
    Console.WriteLine();
    c.PrintAllProduct();
}