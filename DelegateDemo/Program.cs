class Program
{
    public delegate int myDelegate1(int x, int y);
    static int Cong(int x, int y)
    {
        return x+y;
    }
    static int Tru(int x, int y)
    {
        return x - y;
    }
    public delegate int[] myDelegate2(int n);
    static int[] DanhSach(int n)
    {
        List<int> list = new List<int>();
        for (int i = 2;i <= n; i++)
        {
            list.Add(i);
            i++;
        }
        return list.ToArray();
    }
    static int[] DanhSachSoNguyenTo(int n)
    {
        List<int> list = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            int count = 0;
            for(int j =1; j <= i; j++)
            {
                if(i%j == 0)
                {
                    count ++;
                }
            }
            if(count == 2)
            {
                list.Add(i);
            }
            
        }
        return list.ToArray();
    }

    public static void Main(string[] args)
    {
        myDelegate1 d1 = new myDelegate1(Cong);
        Console.WriteLine("Tong cua 5 va 8 = "+d1(5,8));
        myDelegate1 d2 = new myDelegate1(Tru);
        Console.WriteLine("Hieu cua 5 va 8 = " + d2(5, 8));

        myDelegate2 i1 = new myDelegate2(DanhSach);
        int[] arr = i1(10);
        Console.WriteLine("Danh sach so chan");
        foreach (int x in arr) Console.WriteLine(x);

        myDelegate2 i2 = new myDelegate2(DanhSachSoNguyenTo);
        int[] arr2 = i2(20);
        Console.WriteLine("Danh sach so nguyen to");
        foreach (int x1 in arr2) Console.WriteLine(x1);
    }

}