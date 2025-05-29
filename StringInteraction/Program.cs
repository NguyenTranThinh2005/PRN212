using System.Text;

String ho = "Nguyen";
String tenlot = "Thi";
String ten = "Teo";
string fullname =ho +" "+tenlot +" "+ten;
Console.WriteLine(fullname);
//Sb chi su dung 1 o nho
StringBuilder sb = new StringBuilder();
sb.Append(ho);
sb.Append(" ");
sb.Append(tenlot);
sb.Append(" ");
sb.Append(ten);
Console.WriteLine(sb.ToString());