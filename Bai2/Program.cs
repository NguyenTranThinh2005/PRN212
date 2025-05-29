// See https://aka.ms/new-console-template for more information

using System.Text;

void do_calculation(double a,double b,string op)
{
    switch (op)
    {
        case "+": Console.WriteLine("{0}+{1}={2}",a,b,a+b);
            break;
        case "-":
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            break;
        case "*":
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            break;
        case "/":
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            break;
        default:
            Console.WriteLine("Nhap sai roi...");
            break;
    }
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Simple Calculation");
Console.WriteLine("Nhap a:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Nhap b:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Nhap phep tinh");
String op=Console.ReadLine();
do_calculation(a,b,op);
Console.ReadLine();
