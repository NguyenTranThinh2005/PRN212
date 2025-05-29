/*
 Nhap vao 1 so >=0. Neu nhap sai yeu cau nhap lai cho toi khi dung.
Neu nhap dung thi tinh giai thua cua so do.
 */
int n = -1;//nhap sai
while (n < 0)
{
    Console.WriteLine("Nhap n (n <= 0): ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out n) == true)
    {
        if (n >= 0)
        {
            break;

        }
        else
        {
            Console.WriteLine("Nhap >0 pls");
        }
    }
    else
    { 
        Console.WriteLine("Nhap so dum cai");
    }
}
int gt = 1;
for (int i = 1; i <= n; i++)
{
    gt= gt*i;
}
Console.WriteLine($"{n}! ={gt}");