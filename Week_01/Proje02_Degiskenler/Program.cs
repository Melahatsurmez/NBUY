namespace Proje02_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir değişkene isim verirken;
            //1) Alfanümerik karakterler kullanılmaz.(alt tire (_) hariç)
            //2) Türkçe karakter kullanılmaz. (Zorunlu değil.)
            //3) Özel ya da ayrılmış sözcükler kullanılmaz.
            //4) Değişken isimleri büyük küçük harf duyarlıdır.

            //string adSoyad;
            //adSoyad = "Alex de Souza";
            //Console.WriteLine(adSoyad);
            //Console.WriteLine("adSoyad");

            //int yas;
            //yas = 19;
            //Console.WriteLine(yas);

            //string adSoyad = "Ahmet Candan";
            //Console.WriteLine(adSoyad);

            //Console.WriteLine("Adı:" + adSoyad + ", Yaş:" + yas);

            //TAM SAYI
            byte sayi1 = 255;
            int sayi2 = 5545895;
            long sayi3 = 92544484515441154;
            Console.WriteLine(int.MinValue + "-" + int.MinValue);
            Console.WriteLine(byte.MinValue + "-" + byte.MaxValue);
            Console.WriteLine(long.MinValue + "-" + long.MaxValue);

            //string sayi4 = "15";
            //Console.WriteLine(sayi4+2);

            //ONDALIKLI
            // Genelde ondalık sayılarda çok önemli işlemler için float, parasal için decimal kullanılır.
            float a = 10.5f;
            double b = 20.6;
            decimal c = 100.65m;

            //KARAKTER ve METİN
            string name = "Melahat Sürmez";
            char cinsiyet = 'K';
            // Char yazarken tek tırnak içinde yazılır.

            //MANTIKSAL
            bool evliMi = false;
            bool evliMİ = true;



            
            
        
        }
    }
}