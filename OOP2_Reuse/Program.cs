/* Cai ham tinh tuoi vao employee ma khong dung vao prj oop2
 */
using OOP2;
using OOP2_Reuse;

FullTimeEmployee f1 = new FullTimeEmployee()
{
    Id = 1,
    Name = "Someone",
    IdCard = "1234",
    dob = new DateTime(1992, 12, 12),
};
Console.WriteLine("thong tin dau tien co them tinh tuoi:");
Console.WriteLine(f1);
Console.WriteLine("Tinh tuoi:"+f1.tinhTuoi());