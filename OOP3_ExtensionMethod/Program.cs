using OOP3_ExtensionMethod;

int n1 = 5;
Console.WriteLine("Tong tu 1 toi 5 = "+n1.tongTu1ToiN());
int n2 = 10;
Console.WriteLine("Tong tu 1 toi 10 = "+10.tongTu1ToiN());

Console.WriteLine("10+20= " + 10.Cong(20));

int[] arr = new int[10];
arr.taoMang();
Console.WriteLine("Mang truoc sap xep:");
arr.xuatMang();
Console.WriteLine("Mang sau khi sap xep tang dan:");
arr.sapXepTangDan();
arr.xuatMang();