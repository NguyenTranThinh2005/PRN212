using DemoLinQSQL;

string connectionString = @"server=THINH1;database = MyStore;uid=sa;pwd=12345";
MyStoreDataContext context = new MyStoreDataContext(connectionString);
//Cau 1:Truy van toan bo danh muc 
var dsdm = context.Categories.ToList();
Console.WriteLine("Danh sach danh muc:");
dsdm.ForEach(x => Console.WriteLine(x.CategoryID+"\t"+x.CategoryName));
//Cau 2: Dung query syntax de loc ra toan bo san pham
var pList = from p in context.Products
            select p;
Console.WriteLine("Danh sach san pham");
foreach (var p in pList)
{
    Console.WriteLine(p.ProductID+"\t"+p.ProductName+"\t"+p.UnitPrice);
}
//Cau 3: Tim danh muc khi biet ma danh muc
int catCode = 3;
Category category = context.Categories.FirstOrDefault(x=>x.CategoryID==catCode);
if(category == null)
{
    Console.WriteLine("Khong tim thay Category "+catCode);
} else Console.WriteLine("Tim thay Category "+catCode);
Console.WriteLine(category.CategoryID+"\t"+category.CategoryName);
//Cau 4: Loc ra top 3 san pham co gia lon nhat
var dssptop3 = context.Products.OrderByDescending(p => p.UnitPrice).Take(3);
Console.WriteLine("Danh sach top 3 san pham dat nhat");
foreach(var p in dssptop3)
{
    Console.WriteLine(p.ProductID+"\t"+p.ProductName+"\t"+p.UnitPrice);
}
//cau 5: Them moi 1 danh muc
//Category c1 = new Category();
//c1.CategoryName = "Hang 2nd hand dasdsadsadsadsadwqdegrgtrehyu";
//context.Categories.InsertOnSubmit(c1);
//context.SubmitChanges();

//Cau 6: Sua ten danh muc
//B1: Tim ten danh muc
//B2: Thay thi sua (Beverages)
Category c1 = context.Categories.FirstOrDefault(c => c.CategoryID == 1);
if(c1 != null)
{
    c1.CategoryName = "Hang gia dung";
    context.SubmitChanges();
}
//Cau 7: Xoa danh muc khi biet ma danh muc
//Category c2 = context.Categories.FirstOrDefault(c=>c.CategoryID == 2);
//if(c2 != null)
//{
//    context.Categories.DeleteOnSubmit(c2);
//    context.SubmitChanges();
//}
//Cau 8: xoa tat ca danh muc khi chua co bat ki san pham nao
var dssp_empty_Product = context.Categories.Where(c=>c.Products.Count()==0).ToList();
context.SubmitChanges();
//Cau 9: them nhieu danh muc cung luc
List<Category> categories = new List<Category>();
categories.Add(new Category() {CategoryName="Hang dien tu",});
categories.Add(new Category() {CategoryName="Hang hoa chat",});
categories.Add(new Category() {CategoryName="Hang random",});
categories.Add(new Category() {CategoryName="Hang nham nhi",});
context.Categories.InsertAllOnSubmit(categories);
context.SubmitChanges();