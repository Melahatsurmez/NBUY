using Proje02_DatabaseFirst.efcore;
NorthwindContext context=new NorthwindContext();
//1//Customer Listesi alıyor
// List<Customer> customers= context.Customers.ToList();
// foreach(var customer in customers)
// {
//     Console.WriteLine(customer.CompanyName + " " + customer.ContactName);
// }

//2//Londonda yaşayan custemorlarıın listesi
// List<Customer> customers= context.Customers.Where(c=>c.City=="London").ToList();
// foreach (var customer in customers)
// {
        // Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Phone: {customer.Phone}");
// }
// Console.WriteLine("Bitti...");

//3// Londonda yaşayan customerların sadece CompanyName ve ContactNamelerini listeleyelim
// var customers= context
// .Customers
// .Select(c=>new{c.CompanyName,c.ContactName,c.City})
// .Where(c=>c.City=="London")
// .ToList();
// foreach (var customer in customers)
// {
//     Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Contact Name: {customer.ContactName}");
// }
// Console.WriteLine("Bitti...");

//Londonda yaşayan customerların sadece CompanyName ve ContactNamelerini listeleyelim;
//4//Nesne Kullanarak

// List<CustomerModel> customers= context
//     .Customers
//     .Select(c=>new CustomerModel() {
//         CompanyName=c.CompanyName,
//         ContactName=c.ContactName,
//         City=c.City
//         })
//     .Where(c=>c.City=="London")
//     .ToList();
// foreach (var customer in customers)
// {
//     Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Contact Name: {customer.ContactName}");
// }
// Console.WriteLine("Bitti...");

//Beverages kategorisindeki ürünlerin listesi
// var bevaragesProducts=context
//     .Products
//     .Where(p=>p.Category.CategoryName=="Beverages") //p.CategoryID==1 de denilebilirdi ama şuan inner join yapmış olduk
//     .ToList();
// foreach (var p in bevaragesProducts)
// {
//     System.Console.WriteLine(p.ProductName); //burasıda eski hali yukarıdaki comment gibi
// }

//Suppliers tablosundaki Germany de yaşayanları listeleyin
// var germanySuppliers= context
//     .Suppliers
//     .Where(s=>s.Country=="Germany")
//     .ToList();
// foreach (var s in germanySuppliers)
// {
//     System.Console.WriteLine(s.CompanyName);
// }

//Nancy adlı çalışanın yaptığı satışlar ve adet
var ordersOfNancy=context
    .Orders
    .Where(o=>o.Employee.FirstName=="Nancy" && o.ShipCountry=="Brazil")
    .ToList();

foreach (var o in ordersOfNancy)
{
    System.Console.WriteLine(o.OrderId);
}
System.Console.WriteLine($"toplam satış sayısı:{ordersOfNancy.Count()}");
class CustomerModel
{
    public string? CompanyName { get; set; }     
    public string? ContactName { get; set; }
    public string? City { get; set; }
}