int[] arr = { 20, 12, 45, 23, 1, 24, 55, 123, 5, 67 };
/*Cach 1: loc ra so chan bang Method Syntax
 * 
 */
var arr_even = arr.Where(x => x % 2 == 0);
Console.WriteLine("Cac so chan dung Method Syntax");
arr_even.ToList().ForEach(x => Console.WriteLine(x));
//Cach 2: Dung Query syntax
var arr2_even = from x in arr
                where(x % 2==0)
                select x;
Console.WriteLine("So chan = query syntax");
arr2_even.ToList().ForEach(x => Console.WriteLine(x));
/*Cau 2: Tang gia tri le len 2 don vi
 */
var arr2 = arr.Where(x => x %2!=0).Select(x => x+2);

Console.WriteLine("Du lieu so le cong len 2 don vi");
arr2.ToList().ForEach(x => Console.WriteLine(x));
/*Sap xep phan tu tang dan
 */
var arr3 = from x in arr
           orderby x ascending
           select x;

/*Sap xep giam dan 
 */
var arr4 = from x in arr
           orderby x descending
           select x;
/* Dem so le
 */
Console.WriteLine("So le la ="+arr.Where(x=>x%2!=0).Count());
int sole = (from x in arr
            where x%2!=0
            select x).Count();

