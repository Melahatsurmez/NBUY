namespace Proje05_MetinselMetotlar;
class Program
{
    static void Main(string[] args)
    {
        //Bu projede metinsel işlemlere dair bazı metotlar öğreneceğiz.
        //string metin = "Wissen Akademie";
        //int uzunluk = metin.Length;
        //Console.WriteLine($"Uzunluk: {uzunluk}");
        //Console.WriteLine($"{metin} metni {uzunluk} karakterdir.");

        //string metin = "WİSSEN";
        //string kucukMetin= metin.ToLower();
        //Console.WriteLine(kucukMetin);
        //string buyukMetin= kucukMetin.ToUpper();
        //Console.WriteLine(buyukMetin);

        //string m1 = "Wissen Akademi";
        //string m2 = "Wissen";
        //int sonuc= String.Compare(m1, m2);
        //Console.WriteLine(m1);
        //Console.WriteLine(m2);
        //Console.WriteLine(sonuc);

        //Console.Write("Birinci metni giriniz:");
        //string m1=Console.ReadLine();
        //Console.Write("İkinci metni giriniz:");
        //string m2=Console.ReadLine();
        //int sonuc= String.Compare(m1,m2);

        //if (sonuc==0)
        //{
        //    Console.WriteLine("Girilen iki metin birbirine EŞİTTİR!");
        //}
        //else
        //{
        //    Console.WriteLine("Girilen iki metin birbirinden FARKLIDIR!");
        //}


        //string m1 = "İşkur";
        //string m2 = "Eğitimleri";
        //string m3 = " Wissen";
        ////string sonuc = m1 + m2 + m3;    
        //string sonuc = String.Concat(m1,m2,m3); //concatte metin birleştirir.
        //Console.WriteLine(sonuc);

        //string ad = "Melahat";
        //int yas = 23;
        //string okul = "BAU";

        ////+ile
        //string sonuc1 = "Benim adım" + ad + "." + yas + "yaşındayım. Okuduğum okulun adı" + okul;
        //Console.WriteLine(sonuc1);

        // concat
        //string sonuc2 = String.Concat("Benim adım", ad, ".", yas, "yaşındayım.Okuduğum okulun adı", okul);
        //Console.WriteLine(sonuc2);
        // $
        //string sonuc3 = $"Benim adım{ad}.{yas} yaşındayım. Okuduğum okulun adı {okul}";
        //Console.WriteLine(sonuc3);


        //Benim adım Melahat.23 yaşındayım. Okuduğum okulun adı BAU.
        // + İLE
        // CONCAT
        // $ İLE


        //string metin = "Merhaba. Bu hafta eğitime başladık.";
        //bool sonuc = metin.Contains("wissen");
        //Console.WriteLine(sonuc);

        //string adres = "İstanbul Şehit Ali mh. Can sk. No:6 Kadıköy/İstanbul";
        //bool sonuc = adres.EndsWith("İstanbul");
        //bool sonuc2 = adres.StartsWith("İstanbul");
        //Console.WriteLine(sonuc + "," + sonuc2);

        //adres içindeki C harfi kaçıncı sıradadır?
        //string aranacakİfade = "c";
        //int siraNo= adres.ToUpper().IndexOf(aranacakİfade.ToUpper()); //ToLower da denebilir önce hepsini küçük hark yapıp sonra arar.
        //Console.WriteLine($"C harfi {adres} içinde,{siraNo}.sıradadır.");

        //string aranacakİfade = "Şehit Ali";
        //int siraNo = adres.ToUpper().IndexOf(aranacakİfade.ToUpper()); //ToLower da denebilir önce hepsini küçük hark yapıp sonra arar.
        //Console.WriteLine($"{aranacakİfade}ifadesi {adres} içinde,{siraNo}.sıradadır.");



        //string metin = "Wissen akademie";
        //Console.WriteLine($"Metnin ilk hali: {metin}");
        //Console.WriteLine($"Metnin ilk hali: {metin}");
        //Console.WriteLine($"Akademi ifadesi silindikten sonraki hali:{metin.Remove(7)}");
        //Console.WriteLine($"Akademmi ifadesi silindikten sonraki hali:{metin.Remove(7, 3)}");


        string urunAd = "IPhone 13 Pro";
        // iphone-13-pro
        //string sonuc = (urunAd.Replace(" ", "-")).ToLower();
        string sonuc = urunAd.ToLower().Replace(" ", "-");
        Console.WriteLine(sonuc);
        string sonuc2 = urunAd.Replace("IPhone", "Samsung");
        Console.WriteLine(sonuc2);
        













    }
}
