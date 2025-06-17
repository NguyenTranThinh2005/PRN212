using Lucy_SaleManagement;

string connectionString = @"server=THINH1;database = Lucy_SalesData;uid=sa;pwd=12345";
Lucy_SalesDataDataContext context = new Lucy_SalesDataDataContext(connectionString);

//Cau 1: Lay thong tin chi tiet khach hang khi biet ma
int mkh = 1;
Customer customer = context.Customers.FirstOrDefault(c=>c.CustomerID== mkh);
if (customer != null)
{
    Console.WriteLine("Thong tin khac hang:" +customer.CustomerID+"\t"+customer.ContactName);
}
//Cau 2: loc ra danh sach hoa don cua khach hang tim thay
if(customer != null)
{
    Console.WriteLine("Danh sach hoa don cua khach hang");
	foreach (Order item in customer.Orders)
	{
        decimal totalprice = item.Order_Details.Sum(odd => odd.Quantity * (decimal)odd.UnitPrice * (decimal)odd.Discount);
       
        Console.WriteLine(item.OrderID+"\t"+item.OrderDate.ToString("dd/MM/yyyy")+"\t"+totalprice);
	}
}

//Cau 3:Bo sung them 1 cot hien thi tri gia hoa don

