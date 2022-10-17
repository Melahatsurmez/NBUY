namespace Proje12_OOP_Work_01_Cozum
{
    interface IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
    }
    class Bolum: IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
    }
    class Ogrenci :IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int OgrNo { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

    }
    internal class Program
    {
        static string GirisYap(string baslik)
        {
            Console.Write(baslik);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            List<Bolum> bolumler = new List<Bolum>();
            for (int i = 0; i < 2; i++)
            {
                Bolum bolum = new Bolum();
                Console.Write($"{i+1}. Bölüm Id: ");
                bolum.Id= int.Parse(Console.ReadLine());
                Console.Write($"{i+1}.Bölüm Adı: ");
                bolum.Ad = Console.ReadLine();
                Console.Write($"{i+1}.Bölümün Açıklaması: ");
                bolum.Aciklama = Console.ReadLine();
                List<Ogrenci>ogrenciler= new List<Ogrenci>();
                Console.WriteLine($"{bolum.Ad}. Bölümü Öğrencileri");
                Console.WriteLine("******************");

                for (int j = 0; j < 3; j++)
                {
                    Ogrenci ogrenci = new Ogrenci();
                    Console.Write($"{j+1}.Öğrenci Id: ");
                    ogrenci.Id = int.Parse(Console.ReadLine());
                    Console.Write($"{j + 1}.Öğrenci No: ");
                    ogrenci.OgrNo = int.Parse(Console.ReadLine());
                    Console.Write($"{j + 1}.Öğrenci Ad : ");
                    ogrenci.Ad = Console.ReadLine();
                    Console.Write($"{j + 1}.Öğrenci Soyad: ");
                    ogrenci.Soyad = Console.ReadLine();
                    Console.Write($"{j + 1}.Öğrenci Yaş: ");
                    ogrenci.Yas = int.Parse(Console.ReadLine());
                    ogrenciler.Add(ogrenci);
                    Console.WriteLine("******************");

                }
                bolum.Ogrenciler = ogrenciler;
                bolumler.Add(bolum);
                Console.WriteLine("******************");



            }
            foreach (var bolum in bolumler)
            {
                Console.WriteLine($"Bölüm Id: {bolum.Id} - Bölüm Adı: {bolum.Ad} - Bölüm Açıklaması: {bolum.Aciklama}");
                foreach (var ogrenci in bolum.Ogrenciler)
                {
                    Console.WriteLine($"Öğrenci Id: {ogrenci.Id} Öğrenci No: {ogrenci.OgrNo} Öğrenci Ad Soyad: {ogrenci.Ad}{ogrenci.Soyad} Öğrenci Yaş: {ogrenci.Yas} ");
                }

            }
            

            Console.ReadLine();
        }
    }
}