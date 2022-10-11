namespace Proje09_Interface
{

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
    internal class Program
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
            Yonetici yonetici1= new Yonetici();
            Yonetici yonetici2 = new Yonetici("Alex de Souza", "Rio de Jenario", "5000","Futbol");
            
        }
    }
}