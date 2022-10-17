namespace Proje14_Value_Reference_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 45;
            int b = a * 2;

            Random rnd= new Random();
            
            Kisi kisi1 = new Kisi();
            kisi1.Ad = "Engin";
            kisi1.Yas = 47;
            kisi1.Meslek = "Software Developer";

            Kisi kisi2 = new Kisi();
            kisi2.Ad = "Saliha";
            kisi2.Yas = 47;
            kisi2.Meslek = "Eğitmen";

            Kisi kisi3= new Kisi();
            kisi3.Ad = "Cemal";
            kisi3.Yas = 66;
            kisi3.Meslek = "Şair";

            Araba araba1 = new Araba();
            araba1.Marka = "Opel";
            araba1.Renk = "Kırmızı";

            DateTime bugun= DateTime.Now;
            Random rnd2= new Random();
        }
        class Kisi
        {
            public string? Ad { get; set; } //soru işareti yeşil alt çizginin gitmesi için
            public int Yas { get; set; }
            public string? Meslek { get; set; }

        }
        class Araba
        {
            public string Marka { get; set; } //public olanlar dışardan erişilebilirken private olanlar 
            public string Renk { get; set; }   //klasör içinden erişilebilir
            private string VitesTuru { get; set; }
            /* Erişiö nelirleyici: Bir property nin dışarıdan yani içinde bulunduğu classın dışından erişim seviyesini belirleyen anahtar sözcüklere denir. Eğer herhangi bir erişim belirleyici kullanılmamışsa, default erişim belirleyicilere
             * Erişim belirleyiciler:
             * 1) puplic
             * 2) private
             * 3) internal
             * 4) protected
             */
        }
    }
}