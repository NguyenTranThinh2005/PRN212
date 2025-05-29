using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_ExtensionMethod
{
    public static class MyUtils
    {
        /*Cài đặt 1 hàm tongTu1ToiN vào kiểu int của Microsoft
         */
        public static int tongTu1ToiN(this int n)//this int nghia la bat ki bien nao co kieu du lieu int se dung ham nay
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        public static int Cong(this int a, int b)
        {
            return a + b;
        }
        public static void sapXepTangDan(this int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        public static void taoMang(this int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0;i<arr.Length; i++)
            {
                arr[i] = rnd.Next(50);
            }
        }
        public static void xuatMang(this int[] arr)
        {
            foreach (int i in arr)
                Console.WriteLine(i+"\t");
            Console.WriteLine();
        }

    }
}
