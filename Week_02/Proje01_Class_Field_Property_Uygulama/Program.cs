namespace Proje01_Class_Field_Property_Uygulama
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product classımız olaca: Name, Price, Description
            //İstenildiği kadar Product bilgisinin girilmesini sağlayacağız.
            //Kaç adet Product bilgisi girlecegini kullanıcı belirleyecek.
            //Product ekleme işi bitince, eklenmiş Product2lar listelensin.

            //Console.Write("Kaç adet ürün gireceksiniz?: ");
            //int adet = int.Parse(Console.ReadLine());
            //Product[] products = new Product[adet]; //bu kadar adet dizi tanımla( kaç yazdıysak) .lengt demeye gerek kalmadı.
            //Product product; // her seferinde yeni ürün tanımlamamak için; bunu eklemeseydik // olan yer olacaktı
            //for (int i = 0; i < adet; i++)
            //{
            //    //Product product= new Product();
            //    product = new Product();

            //    Console.Write("Product Name: ");
            //    product.Name = Console.ReadLine();

            //    Console.Write("Price: ");
            //    product.Price = decimal.Parse(Console.ReadLine());

            //    Console.Write("Description: ");
            //    product.Description = (Console.ReadLine());

            //    products[i] = product;


            //}
            //Console.WriteLine("Product Name\t Price\tDescription");
            //foreach (var prd in products) //artık içi dolu oldugu için foreach //productyazınca kabul etmez
            //{
            //    Console.WriteLine($"{prd.Name}\t{prd.Price}\t{prd.Despriction}");
            //}

            #region RastgeleDegerUreterek
            Product[] products = new Product[5];
            Product product;
            string[] nameArray = { "Galaxy A50", "HP Notebook", "MacBook Air M2", "Iphone", "LG 27 inç Monitör" };
            string[] descArray = { "İyidir", "Şaşırtıcıdır", "Heyecan vericidir", "Soluğunuzu keser", "Tırttır" };
            decimal[] oldPrices= new decimal[5];
            Random random = new Random();
            Console.WriteLine("Yapılacak zam oranını giriniz: ");
            decimal oran =decimal.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                product = new Product();
                {
                    product.Name = nameArray[random.Next(0, 5)];
                    product.Description = descArray[random.Next(0, 5)];
                    product.Price = random.Next(100, 1001);
                }
                oldPrices[i] = product.Price;
                //product.Price = product.Price * (1 + (oran / 100)); // alttakiyle aynı işlem
                product.Price *= (1 + (oran / 100));
                products[i] = product;
            }

            Console.WriteLine("Product Name".PadRight(30)+"Price".PadRight(10)+"Description");
            int j = 0;
            foreach (var prd in products) //artık içi dolu oldugu için foreach //productyazınca kabul etmez
            {
                Console.WriteLine($"{prd.Name.PadRight(30)}{oldPrices[j].ToString().PadRight(10)}{prd.Price.ToString().PadRight(10)}{prd.Description}");
                j++;
            }
            #endregion

        }
    }
}