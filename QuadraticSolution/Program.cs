using System.Text;

void firstDegreeEquation(double a, double b)
{
   if(a == 0 && b == 0)
    {
        Console.WriteLine("Vo so nghiem");
    } else if(a == 0 && b != 0)
    {
        Console.WriteLine("Vo nghiem");
    }
    else
    {
        Console.WriteLine("X={0}", -b / a);
    }
}

void QuadraticEquation(double a, double b,double c)
{
    if (a == 0)
    {
        firstDegreeEquation(b, c);
    }
    else
    {
        var delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta < 0)
        {
            Console.WriteLine("Vo nghiem");
        }
        else if (delta == 0)
        {
            Console.WriteLine("Nghiem kep X1=X2={0}", -b / 2 * a);

        }
        else
        {
            var x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            var x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Phuong trinh co 2 nghiem phan biet X1={0}; X2={1}", x1, x2);
        }
    }
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Phuong trinh bac 2 a*2+bx+c=0");
Console.WriteLine("Nhap a");
var a = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhap b");
var b = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhap c");
var c = Double.Parse(Console.ReadLine());

QuadraticEquation(a, b, c);
Console.ReadLine();