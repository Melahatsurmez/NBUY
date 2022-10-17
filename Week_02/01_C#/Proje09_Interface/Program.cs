namespace Proje09_Interface
{
    /*Interfaceler için belirtilmediginde default erişim belirleyici publictir.
     * Interfaceler protected, private ya da static olarak işaretlenemezler.
     * Interfaceler içinde çalışabilir kodlar olamaz. yani metotların sadece imzassı bulunur.
     * Bir interface bir başka interface den yada daha çok interfaceden miras alabilir.
     * Bir interface classtan miras alamaz.
     * Eğer bir class bir interfaceden miras alıyorsa miras aldığı ınterfacedeki tüm metotları implemente etmek zorundadır.(Implemente: Miras alınan ınterfacede imzası bulunan tüm metotların içi dolu halleri)
     */
    interface IPersonal
    {
        public string Departman { get; set; }
    }
    interface IKisi
    {
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public string Maas { get; set; }
        public void Bilgi(); //İnterfaceler içindeki metotlarda sadece İMZA bulunur, metodun gövdesi olmaz!
        //Metodun gövdesi nu interfacei miras alan CLLAS içinde doldurulur.
        //Interface new yapılamaz.
    }
    class Yonetici : IKisi , IPersonal
    {
        /// <summary>
        /// Bu metod herhangi bir yönetici bilgisi girmeden yönetici oluşturur
        /// </summary>
        public Yonetici()
        {
            //Kimi zaman AdSoyad adres maas departman bilgisini vermeden de yönetici oluştrmak istedigmiz zaman bu constructor çalışır
        }
        /// <summary>
        /// Bu metot adsoyad adres maas ve departman bilgileri girilerek yönetici oluşturur
        /// </summary>
        /// <param name="adSoyad">ad soyadı gir</param>
        /// <param name="adres">Buraya adresi girin</param>
        /// <param name="maas">Buraya maası girin ama yanlışlıkla string tanımlamışsın</param>
        /// <param name="departman">departmanı gir</param>
        public Yonetici(string adSoyad, string adres, string maas, string departman)
        {
            AdSoyad = adSoyad;
            Adres = adres;
            Maas = maas;
            Departman = departman;
        }

        public string AdSoyad { get; set; }
        public string Maas { get; set; }
        public string Departman { get; set; }
        public string Adres { get; set; }

        public void Bilgi()
        {
            Console.WriteLine();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            /*Bir abstract classtan miras alan classta
             * Eger base classta abstract bir methot varsa, mutlaka override edilmeli
             * Eğer base classta abstract olmayan method varsa onlar aynen kullanılabilir
             * Ancak bazen miras alınan classtaki her methodun, içinin dolu hallerini yazmak zorunlu olsun isteriz
             * Yani bir nevi hepsi abstract olsun isteriz. Bunu yapmak yerine, miras alınan classı, class degil interface şeklinde tanımlarız
             */
            // IPersonal personal= new IPersonal(); //Hatalı kullanım
            // her şey abstract olsun istiyorsak interface kullanmalıyız.
            //Yonetici yonetici1= new Yonetici();
            //Yonetici yonetici2 = new Yonetici("Alex de Souza", "Rio de Jenario", "5000","Futbol");

            Product product1 = new Product()
            {
                Id = 1,
                Name = "IPhone 13",
                Price = 5900,
                Properties = "8 gb ram",
                Ratio = 0.5m,
                CreatedDate = DateTime.Now,
            };
            Console.WriteLine($"Product Name: {product1.Name}(Büyük Harf: {product1.NameToUpper(product1.Name)}) Properties: {product1.Properties}");
            
            Category category1 = new Category();
            {
                Id = 1,
                Name="Telefon",
                CreatedDate= DateTime.Now,
                Description="Bu kategori telefonlar içindir", 
               
                

            };

            Console.ReadLine(  );

        }
    }
}