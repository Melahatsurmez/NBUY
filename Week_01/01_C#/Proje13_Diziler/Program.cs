namespace Proje13_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string adSoyad = "Fatih Candan, Cemal Gündem, Selin Dilci";
            //Console.WriteLine(adSoyad);

            //string[] adlar = new string[7];//İçinde 3 adet string bilgi tutabilecek bir dizi
            //adlar[0] = "Fatih Candan";
            //adlar[1] = "Cemal Gündem";
            //adlar[2] = " Selin Dilci";
            //adlar[3] = "Kemal Kurt";
            //adlar[4] = "Begüm Yonca";
            //adlar[5] = "Selma Halıcı";
            //adlar[6] = "Emre Mor";
            ////Console.WriteLine(adlar[0]);

            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    Console.WriteLine(adlar[i]);
            //}

            //int[] yaslar = new int[3];

            //int[] rakamlar = { 56, 89, 90, 45, 33, 55 };
            //int toplam = 0;
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    toplam+= rakamlar[i];
            //}
            //Console.WriteLine(toplam);

            //string okul = "Wissen akademie";
            //Console.WriteLine(okul[0]);

            //Çalışma: Klavyeden kullanıcının adını soyadını girmesini isteyiniz.
            // Girilen ad soyadı aşağıya doğru büyük Harflerle yazdırınız.
            //Console.WriteLine("Adınızı soyadınızı giriniz: ");
            //string adSoyad = Console.ReadLine().ToUpper();
            //for (int i = 0; i < adSoyad.Length; i++)
            //{
            //    Console.WriteLine(adSoyad[i]);
            //}

            //Console.Write("Bir metin giriniz: ");  /n = enter yapmışgibi alta yazar
            //string girilenMetin = Console.ReadLine().ToLower();
            //Console.Write("Hangi karakterin sırasını bulmamı istersiniz?");
            //string karakter= Console.ReadLine().ToLower();
            //int siraNo = girilenMetin.IndexOf(karakter)+1;
            //Console.Clear();
            //Console.WriteLine($"Girilen Metin:{girilenMetin}\n Aradığınız Karakter: {karakter}\n Aradığınız karakterin Girilen Metimndeki Sırası: {siraNo}");


            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}.Eleman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine();


            //int enBuyuk = rakamlar[0];
            //int enKucuk= rakamlar[0];
            //for (int i = 1; i < rakamlar.Length; i++)
            //{
            //    if (rakamlar[i]>enBuyuk)
            //    {
            //        enBuyuk = rakamlar[i];
            //    }
            //    if (rakamlar[i]<enKucuk)
            //    {
            //        enKucuk= rakamlar[i];
            //    }
            //}
            //Console.WriteLine(enKucuk);
            //Console.WriteLine(enBuyuk);


            //kendimiz en büyük sayıyı buluyoruz.

            //Console.WriteLine($"En küçük:\t{rakamlar.Min()}");
            //Console.WriteLine($"En büuük:\t{rakamlar.Max()}");

            //İsteğe bağlı ödev: Bu diziyi küçükten büyüğe sıralayınız


            //Console.WriteLine("Dizinin Ters çevrilmiş Hali");
            //Console.WriteLine("****************************");
            //Array.Reverse(rakamlar);
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.Eleman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Dizinin Küçükten Büyüğe Sıralanmış Hali");
            //Console.WriteLine("***************************************");
            //Array.Sort(rakamlar); // sort default olarak küçükten sıralamasını yapar
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.Eleman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Dizinin Büyükten Küçüğe Sıralanmış Hali");
            //Console.WriteLine("***************************************");
            //Array.Sort(rakamlar); // sort default olarak küçükten sıralamasını yapar.
            //Array.Reverse(rakamlar);
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.Eleman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine();

            //ÖRNEKLER
            //Örnek-1: sayılar dizisinin elemanlarının ortalamasını bulup ekrana yazdırınız
            //int[] sayilar = { 5, -16, 8, 12, -15, 78, 90, 0 };
            //int toplam = sayilar.Sum();
            //Console.WriteLine($"Toplam:{toplam}");
            //Örnek-2: Sayıları dizisindeki çift sayıları ekrana yazdıralım.
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[1]%2==0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}
            //Örnek-3: Sayılar dizisindeki sayıları yanlarında pozitif, negatif ya da işaretsiz olma bilgileriyle yazdıralım.
            //string tip = "";
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    tip = sayilar[i] > 0 ? "Pozitif" : 
            //            sayilar[i] < 0 ? "Negatif" : 
            //                "İşaretsiz";
            //    Console.WriteLine($"{i+1}.Sayı:{sayilar[i]} - Tipi: {tip}");
            //}

            //Örnek-4: Kullanıcının girecegi bir metnin içerisindeki sesli harf sayısını ekrana yazdıralım
            //char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            //int sesliHarfAdedi = 0;
            //Console.Write("Bir metin giriniz:");
            //string girilenMetin = Console.ReadLine().ToLower();
            //for (int i = 0; i < girilenMetin.Length; i++)
            //{
            //    if (sesliHarfler.Contains(girilenMetin[i]))
            //    {
            //        sesliHarfAdedi++;
            //    }
            //}
            //Console.WriteLine(sesliHarfAdedi);
            //Örnek-5: Klavyeden girilen bir cümledeki yine klavyeden girilecek bir kelimenin  kaç kez geçtiğini bulduralım
            //string ornekMetin = "Engin Niyazi Ergül";
            //string[] sozcukDizisi = ornekMetin.Split(" ");
            //for (int i = 0; i < sozcukDizisi.Length; i++)
            //{
            //    Console.WriteLine(sozcukDizisi[i]);
            //}
            //int sozcukAdedi = 0;
            //Console.Write("Cümleyi giriniz: ");
            //string girilenCumle= Console.ReadLine();
            //Console.Write("Adedini bulmak istediğiniz sözcüğü giriniz: ");
            //string sayilacakSozcuk = Console.ReadLine();
            //string[ ]girilenCumleninDiziHali = girilenCumle.Split(" ");
            //for (int i = 0; i < girilenCumleninDiziHali.Length; i++)
            //{
            //    if (sayilacakSozcuk.ToLower()== girilenCumleninDiziHali[i].ToString().ToLower())
            //    {
            //        sozcukAdedi++;
            //    }
            //}
            //Console.WriteLine($"'{girilenCumle}' cümlesi içinde {sayilacakSozcuk} sözcüğü '{sozcukAdedi}' kez geçmektedir!");
            //***************
            //ARAŞTIRMA ÖDEVİ: Çok boyutlu dizileri araştırınız.
            //***************

            //***************
            //Proje Ödevi:
            /*
             *  İçinde Türkçe karalterler hariç tüm karakterler,0-9 arası rakamlar, nokta, virgül, artı(+), eksi(-), karakterleri bulunabilecek toplam uzunluğu 6 karakter olacak şekilde RASTGELE ŞİFRE üreten programı yazınız.
             */             
            //***************
            
        }
    }
}