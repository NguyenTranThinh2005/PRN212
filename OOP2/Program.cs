using OOP2;

FullTimeEmployee obama = new FullTimeEmployee()
{
    Id = 1,
    IdCard = "1245",
    Name = "Tententenz",
    dob = new DateTime(1960, 02, 12)
};
Console.WriteLine("---First Employee---");
Console.WriteLine($"Id={obama.Id}");
Console.WriteLine($"IdCard={obama.IdCard}");
Console.WriteLine($"Name={obama.Name}");
Console.WriteLine($"dob"+obama.dob.ToString("dd/MM/yyyy"));
Console.WriteLine("Muc luong=" + obama.calSalary());

PartTimeEmployee p1 = new PartTimeEmployee()
{
    Id = 1,
    IdCard = "234",
    Name = "DoNamTrump",
    dob = new DateTime(1980 / 12 / 20),
    workingHrs = 4,
};

Console.WriteLine("---First ParttimeEmployee---");
Console.WriteLine($"Id={p1.Id}");
Console.WriteLine($"IdCard={p1.IdCard}");
Console.WriteLine($"Name={p1.Name}");
Console.WriteLine($"dob" + p1.dob.ToString("dd/MM/yyyy"));
Console.WriteLine("Muc luong=" + p1.calSalary());

Console.WriteLine("---sd toString---");
Console.WriteLine(obama);
Console.WriteLine(p1);