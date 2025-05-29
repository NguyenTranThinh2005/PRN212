/* su dung generic list de quan li nhan su
 * thuc hien day du tinh nang CRUD
 * Cau1: Dung List de tao 5 Employee trong do 4 Employee la chinh thuc, 1 la thoi vu
 */
using OOP2;

List<Employee> employees = new List<Employee>();
FullTimeEmployee f0 = new FullTimeEmployee()
{
    Id = 1,
    Name = "f1",
    IdCard = "0123",
    dob = new DateTime(1987, 12, 04),

};
employees.Add(f0);
FullTimeEmployee f1 = new FullTimeEmployee()
{
    Id = 2,
    Name = "f2",
    IdCard = "0123",
    dob = new DateTime(1967, 11, 04),

};
employees.Add(f1);
FullTimeEmployee f2 = new FullTimeEmployee()
{
    Id = 3,
    Name = "f3",
    IdCard = "0123",
    dob = new DateTime(1977, 12, 24),

};
employees.Add(f2);
FullTimeEmployee f3 = new FullTimeEmployee()
{
    Id = 4,
    Name = "f4",
    IdCard = "0123",
    dob = new DateTime(1997, 12, 04),

};
employees.Add(f3);
PartTimeEmployee part = new PartTimeEmployee()
{
    Id = 5,
    Name = "P1",
    IdCard = "23456",
    dob = new DateTime(1999, 04, 12),
};
employees.Add(part);
//Cau 2: xuat toan bo nhan su
//c1
/*Console.WriteLine("Danh sach nhan su: ");
employees.ForEach(f => Console.WriteLine(f));
*/
//c2
foreach (var f in employees)
    Console.WriteLine(f);
//Cau 3: loc ra nhan su chinh thucs va tinh tong luong
List<FullTimeEmployee> fList = employees.OfType<FullTimeEmployee>().ToList();
Console.WriteLine("---Danh sach Fulltime---");
fList.ForEach(f => Console.WriteLine(f));
Console.WriteLine("---Cach 2---");
List<FullTimeEmployee> fList2 = new List<FullTimeEmployee>();
foreach (var f in employees)
{
    if(f is FullTimeEmployee)
    {
        fList2.Add(f as FullTimeEmployee);
    }
}
// Tinh tong luong
double sum = fList2.Sum(f => f.calSalary());
Console.WriteLine("Tong luong: "+sum);

//Cau 4: Sap xep danh sach nhan su theo ngay thang nam sinh
for (int i = 0; i < employees.Count; i++)
{
    for (int j = i + 1; j < employees.Count; j++)
    {
        Employee ei = employees[i];
        Employee ej = employees[j];
        if (ei.dob > ej.dob)
        {
            {
                employees[i] = ej;
                employees[j] = ei;
            }
        }
    }
}
Console.WriteLine("Sau khi sap xep:");
fList.ForEach(f => Console.WriteLine(f));
//Cau 5: Sua thong tin nhan vien
#region Sua thong tin nhan vien
do
{
    Console.WriteLine("Chon Id nhan vien muon chinh sua: ");
    var id = int.Parse(Console.ReadLine());
    bool found = false;
    foreach (var f in employees)
    {
        if (f.Id == id)
        {
            found = true;
            Console.WriteLine("Thong tin nhan vien hien tai:");
            Console.WriteLine(f);
            Console.WriteLine("Nhap id moi(Nhan 0 de bo qua):");
            int newId = int.Parse(Console.ReadLine());
            if (newId != 0)
            {
                f.Id = newId;

            }
            Console.WriteLine("Nhap ten moi(Nhan Enter de bo qua):");
            string newName = Console.ReadLine();
            if (!string.IsNullOrEmpty(newName))
            {
                f.Name = newName;

            }
            Console.WriteLine("Nhap cccd moi(Nhan Enter de bo qua):");
            string newIdCard = Console.ReadLine();
            if (!string.IsNullOrEmpty(newIdCard))
            {
                f.IdCard = newIdCard;

            }
            Console.WriteLine("Nhap dob moi(Nhan Enter de bo qua):");
            string newDob = Console.ReadLine();
            if (!string.IsNullOrEmpty(newDob))
            {
                if (DateTime.TryParseExact(newDob, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDob))
                {
                    f.dob = parsedDob;
                }
                else
                {
                    Console.WriteLine("Ngay sinh khong hop le");

                }

            }
            Console.WriteLine("Thong tin nhan vien sau chinh sua:");
            Console.WriteLine(f);
            break;
        }
    }
        if(!found)
        {
            Console.WriteLine("Khong tim thay id nhan vien (Nhan bat ki de tiep tuc hoac an q de thoat):");
            string quit = Console.ReadLine();
            if (quit == "q")
            {
                break;
            }
        }
    
} while (true);
#endregion
//Cau 6: Xoa thong tin 
do
{
    Console.WriteLine("Nhap id nhan vien muon xoa: ");
    int id = int.Parse(Console.ReadLine());

    var foundEmp = employees.FirstOrDefault(f => f.Id == id);

    if (foundEmp != null)
    {
        Console.WriteLine("Thong tin nhan vien hien tai:");
        Console.WriteLine(foundEmp);

        Console.WriteLine("Xoa nhan vien? (Nhan Y de xac nhan):");
        string option = Console.ReadLine();

        if (option?.ToUpper() == "Y")
        {
            employees.Remove(foundEmp);
            Console.WriteLine("Da xoa nhan vien");
        }
        else
        {
            Console.WriteLine("Huy xoa nhan vien.");
        }
    }
    else
    {
        Console.WriteLine("Khong tim thay id nhan vien");
    }

    Console.WriteLine("An phim bat ki de tiep tuc hoac 'q' de thoat.");
    string input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

} while (true);
