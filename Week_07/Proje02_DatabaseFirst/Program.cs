using Proje02_DatabaseFirst;
using Proje02_DatabaseFirst.efcore;

 var mt=new MultiTable();
 //mt.MusteriSayisi();
 //mt.SatisYapilanMusteriler();
 //mt.SatisYapilmayanMusteriler();
 mt. MusteriSatisListesi();






// NorthwindContext context=new NorthwindContext();
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
// var ordersOfNancy=context
//     .Orders
//     .Where(o=>o.Employee.FirstName=="Nancy" && o.ShipCountry=="Brazil")
//     .ToList();

// foreach (var o in ordersOfNancy)
// {
//     System.Console.WriteLine(o.OrderId);
// }
// System.Console.WriteLine($"Toplam satış sayısı:{ordersOfNancy.Count()}");

//Productları ID'ye göre büyükten küçüğe listeleyelim.
// var products=context 
//     .Products
//     .OrderByDescending(p=>p.ProductId)
//     .ToList();
//     foreach (var p in products)
//     {
//         System.Console.WriteLine($"{p.ProductId} / {p.ProductName}");
//     }

//En son satılan 5 ürünü sıralayalım.
// var products=context 
//     .Products
//     .OrderByDescending(p=>p.ProductId)
//     .Take(5)
//     .ToList();
//     foreach (var p in products)
//     {
//         System.Console.WriteLine($"{p.ProductId} / {p.ProductName}");
//     }

//Fiyatı 10 ile 20 arasında olan ürünlerin adını ve fiyatını getirip listeleyelim, fiyata göre küçükten büyüğe sıralayalım.
// var products=context 
//     .Products
    
//     .Where(p=>p.UnitPrice>=10 && p.UnitPrice<=20)
//     .Select(p=> new {  //Whereden sonra select yazarsak daha sonra sorun çıkmasını engelleyebilir. şuan çalışır         değiştirirsek
//         p.ProductName,
//         p.UnitPrice
//  //Select bunu yazdığımızda foreach kısmına kullanmayacagımız kolonları artık getşrtemeyiz. sadece burda belirttiklerimizi getirtebiliriz select yapmasaydık bize gerekli olmayan kolonlarıda foreach kısmında getirebilirdik.
//     })
//     .OrderBy(p=>p.UnitPrice) //bunu her yerde yazabiliriz ama  to listen önce yazarsak gereksiz kolonlarıda sıralama yapmamış olacak ve gereksiz çalışmayacak.ama senaryoya göre değişir 
//     .ToList();
//     foreach (var p in products)
//     {
//         System.Console.WriteLine($"{p.ProductName} --> {p.UnitPrice}");
//     }

//Beverage kategorisindeki ürünlerin ortalama fiyatını ekrana yazdıralım
// var ortalama=context
//     .Products
//     .Where(p=>p.Category.CategoryName=="Beverages")
//     .Average(p=>p.UnitPrice);

// System.Console.WriteLine($"Beverages Fİyat Ortalaması:{ortalama}");

//Beverages kategorisindeki ürün adedi
// var adet=context
//     .Products
//     // .Where(p=>p.Category.CategoryName=="Beverages")
//     // .Count();
//     .Count(p=>p.Category.CategoryName=="Beverages"); //bu şekildede yazılabilir where yazılmadan
// System.Console.WriteLine($"Beverages Ürün Adedi:{adet}");

//Beveraged ve Condiments kategorilerinde toplam kaç adet ürün vardır
// var ikiurun=context
//     .Products
//     .Where(p=>p.Category.CategoryName=="Beverages" || p.Category.CategoryName=="Condiments")
//     .Count();

// System.Console.WriteLine($"Ürünler toplamı:{ikiurun}");

//Adının içinde tofu geçen ürünleri listeleyelim.
// var products=context
//     .Products
//     .Where(p=>p.ProductName.Contains("tofu"))
//     .ToList();
// foreach (var p in products)
// {
//     System.Console.WriteLine($"{p.ProductName}");
// }

//En ucuz ve en pahalı ürünler hangileridir?
// var minPrice=context.Products.Min(p=>p.UnitPrice);
// var maxPrice=context.Products.Max(p=>p.UnitPrice);

// var minProduct=context
//     .Products
//     .Where(p=>p.UnitPrice==minPrice)
//     .Select(p=> new{
//         p.ProductName,
//         p.UnitPrice
//     }).FirstOrDefault();

// var maxProduct=context
//     .Products
//     .Where(a=>a.UnitPrice==maxPrice)
//     .Select(b=> new{
//         b.ProductName,
//         b.UnitPrice
//     }).FirstOrDefault();

// System.Console.WriteLine($" MinPrice {minPrice} --> Product: {minProduct.ProductName} - {minProduct.UnitPrice}");
// System.Console.WriteLine($" MaxPrice {minPrice} --> Product: {maxProduct.ProductName} - {maxProduct.UnitPrice}");

// var minPrice=context.Products.Min(p=>p.UnitPrice);
// var maxPrice=context.Products.Max(p=>p.UnitPrice);
// var minProducts=context
//     .Products
//     .Where (p=>p.UnitPrice==minPrice)
//     .Select(p=> new{
//         p.ProductName
//     }).ToList();
//     System.Console.WriteLine($" en ucuz ({minPrice}) fiyatlı ürünlerin listesi:");
//     foreach (var p in minProducts)
//     {
//         System.Console.WriteLine(p.ProductName);
//     }

// var maxProducts=context
//     .Products
//     .Where (p=>p.UnitPrice==maxPrice)
//     .Select(p=> new{
//         p.ProductName
//     }).ToList();
//     System.Console.WriteLine($" en Pahalı ({maxPrice}() fiyatlı ürünlerin listesi:");
//     foreach (var p in maxProducts)
//     {
//         System.Console.WriteLine(p.ProductName);
//     }













// class CustomerModel
// {
//     public string? CompanyName { get; set; }     
//     public string? ContactName { get; set; }
//     public string? City { get; set; }
// }