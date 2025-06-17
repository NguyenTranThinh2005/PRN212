using DemoAlasAndClone;

Student s1 = new Student()
{
    Id = 1,Name="Lo Bi Ta"
};
Student s2 = new Student()
{
    Id=2, Name="Do De Mon"
};
//Luc nay Ram cap 2 o nho cho s1 va s2 quan li => s1 doi gia tri k lquan den s2 vi 2 thg o 2 o nho khac nha
//Tuy nhieu neu dung lenh nhu s1 =s2, ve ban chat no hoat dong nhu sau
//s1 tro toi vung nho s2 dang quan li, khong phai s1 = s2. Luc nay s1 chuyen sang quan li o nho cua s2. truog hop 1: o nho s2 se do s1 va s2 quan li
//goi la alias. Nghia la s1 hoac s2 thay doi gia tri o nho s2 thi ca s1 va s2 deu anh huong.
s1 = s2;
s2.Name = "Ten tao ne";
Console.WriteLine("Ten cua s1:"+s1.Name);

//TH2: o nho s1 khong con ai su dung se bi thu hoi nho co che garbage collection

Product p1 = new Product()
{
    Id = 1,
    Name = "P1",
    Price = 20,
    Quantity = 12,

};
Product p2 = new Product()
{
    Id = 2,
    Name = "P2",
    Price = 40,
    Quantity = 10,

};
Product p3 = new Product()
{
    Id = 3,
    Name = "P3",
    Price = 60,
    Quantity = 30,

};
Product p4 = new Product()
{
    Id = 4,
    Name = "P4",
    Price = 80,
    Quantity = 40,

};
Product p5 = p3;
p3= p4;
//O nho cap phat cho p3 co bi thu hoi khong ? Vi sao. Khong bi thu hoi vi p5 dang quan li p3


p1 = p2;
p2.Name = "Thuoc cua P2";
p2.Price = 40;
Console.WriteLine(p1);
//Sao chep du lieu p4 sang p6, giao cho p6 quan li 
Product p6 =p4.clone();
Console.WriteLine("du lieu p6:");
Console.WriteLine(p6);
Console.WriteLine("du lieu p4:");
Console.WriteLine(p4);
p4.Name = "Thuoc cua p4";
Console.WriteLine("du lieu p6:");
Console.WriteLine(p6);
Console.WriteLine("du lieu p4:");
Console.WriteLine(p4);