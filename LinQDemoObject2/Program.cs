using LinQDemoObject2;

ListProduct lp = new ListProduct();
lp.create_Product();
/*Loc ra san pham co gia tu a toi b sd method syntax va query syntax
 */
var result =lp.FilterByPrice2(10,100);
result.ForEach(x => Console.WriteLine(x));
/*Sap xep cac san pham theo don gia giam dan
 */
var result2 = lp.SortPriceDesc();
result2.ForEach(x => Console.WriteLine(x));
/*Tinh tong gia tri san pham trong kho hang
 */
Console.WriteLine("Tong gia tri = "+ lp.sumValue());

