using OOP;
Category c1 = new Category();
c1.id = 1;
c1.name = "San pham 1";
c1.printInfor();

//Employee employee = new Employee();
//employee.Id = 1;
//employee.Name = "Teo";
//employee.Email = "TenTenTenz@gmail.com";
//employee.Phone = "09999999";
//employee.IdCard = "1232134";

//employee.printInfor();
//Console.WriteLine("_____________");
//Console.WriteLine("Id e1 ="+employee.Id);
//Console.WriteLine($"Name cua e1={employee.Name}");

//Employee e1 = new Employee()
//{
//    Id = 12,
//    Name = "Teqq",
//    Email = "random@mgila.com",

//};
//Console.WriteLine();
//e1.printInfor();

Employee e3 = new Employee(3, "Thang", "0123213", "email@gmail.com", "09012321");
Console.WriteLine(e3);

Customer cu1 = new Customer()
{
    Id = "cus1",
    Name = "Lung link",
    Address = "O dau do",
    Email = "random@",
    Phone = "0209121"
};
cu1.printInfor();