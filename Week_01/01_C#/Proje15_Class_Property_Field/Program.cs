namespace Proje15_Class_Property_Field
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.OgrNo = 11;
            ogrenci1.Ad = "Ahmet";
            ogrenci1.Sinif = "9A";

            Ogrenci ogrenci2=new Ogrenci();
            ogrenci2.OgrNo = 12;
            ogrenci2.Ad = "Selim";
            ogrenci2.Sinif = "10B";

            Ogrenci ogrenci3 = new Ogrenci() 
            { 
                OgrNo = 15, 
                Ad = "Umay", 
                Sinif = "10C" 
            };
            int[] sayilar = { 32, 45, 65 }; //aşagıdakiyle aynı
            Ogrenci[] ogrenciler= {ogrenci1,ogrenci2, ogrenci3};
            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine($"Ad:{ogrenciler[i].Ad},Sınıf:{ogrenciler[i].Sinif},OgrNO:{ogrenciler[i].OgrNo}");
            //}

            foreach (var siradakiOgrenci in ogrenciler)
            {
                Console.WriteLine(siradakiOgrenci.Ad + "," + siradakiOgrenci.Sinif);
            }
            //for (int i = 0; i < sayilar.Length; i++)  // for ve foreach le kareleri alma yöntemi
            //{
            //    Console.WriteLine(sayilar[i] * sayilar[i]);
            //}
            //foreach (var siradakiSayi in sayilar)
            //{
            //    Console.WriteLine(siradakiSayi*siradakiSayi);
            //}
        }

        class Ogrenci
        {
            private int ogrNo; //propfull ile yapılır

            public int OgrNo
            {
                get { return ogrNo; }
                set { ogrNo = value; }
            }

            private string? ad;  //Field

            public string Ad  //Property
            {
                get { return ad.ToUpper(); }
                set { ad = value; }
            }

            public string? Sinif { get; set; }
        }
    }
}