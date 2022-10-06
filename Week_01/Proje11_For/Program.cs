namespace Proje11_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i+1}.Hello, World!");
            //}


            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    //toplam = toplam + i; 
            //    toplam += i;
            //}
            //Console.WriteLine($"toplam:{toplam}");

            //1 ile 10 arasındaki çift sayıların toplamını buldurun.

            //modüler bölme: %
            //    10/5=2
            //    10%5=0


            //int toplam = 0;
            //for (int i = 0; i < 10; i=i+2)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);

            //int toplam = 0;
            //for (int i = 1; i <= 10; i = i++)
            //{
            //    if (i%2==0) toplam += i;              
            //}
            //Console.WriteLine(toplam);


            //1-10 arasındaki çift sayıların toplamını ayrı tek sayıların toplamını ayrı gösteriniz.
            //int ciftToplam = 0;
            //int tekToplam = 0;
            //for (int i = 1; i <= 10; i = i++)
            //{
            //    if (i % 2 =/ 0) buna bakkkk eşit değildir.
            //    {
            //        ciftToplam = ciftToplam + i;
            //    }
            //    else
            //    {
            //        tekToplam = tekToplam + i;
            //    }

            //}
            //Console.WriteLine($"Tek sayıların toplamı: {tekToplam}\nÇift sayıların toplamı:{ciftToplam}");


            // Soru: Klavyeden iki sayı girilsin. Bu sayıların arasındaki sayıların toplamını ekrana yazdıralım.
            //Console.Write("1. sayı giriniz: ");
            //int sayi1= Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. sayı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;


            //for (int i = sayi1; i < sayi2; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine($"toplam:{toplam}"); // Burda tam tersini yazınca çalışmıyp o yüzden aşagıdaki yöntemle geliştiriyoruz.

            //Console.Write("1. sayı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. sayı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;

            //if (sayi2>sayi1)
            //{
            //    for (int i = sayi1; i <= sayi2; i++)
            //    {
            //        toplam += i;
            //    }
            //}
            //else
            //{
            //    for (int i = sayi1; i >= sayi2; i--)
            //    {
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine($"toplam:{toplam}");

            // Başka bir çözüm;

            //Console.Write("1. sayı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. sayı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //int min=Math.Min(sayi1, sayi2);
            //int max=Math.Max(sayi1, sayi2);

            //for (int i = min; i <= max; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine($"toplam:{toplam}");

            //SORU: Program kullanıcıdan bir sayı girmesini istesin. Ancak kullanıcı sayı girmeye devam attikçe girilen sayıların toplanmasını sağlayalım. SAYI ADEDİ BELİRSİZDİR!.Uygulamanın bitip ekrana toplamı yazdırabilmesi için kullanıcının sayı yerine exit yazmasını kontrol edeceğiz.
            //int toplam = 0;
            //string girilenDeger = "";
            //string sonucMetin = "";
            //string sonEk = " + ";
            //for (int i = 1; i < 1000000; i++)
            //{
            //    Console.Write($"{i}. Sayıyı giriniz.(Çıkış için exit)[Geçerli toplam]:{toplam}: ");
            //    girilenDeger = Console.ReadLine();
            //    if (girilenDeger.ToLower()=="exit")//if Büyük Harf duyarlıdır!
            //    {
            //        break; //içinde bulunulan döngünün, tamamlanmasını beklemeden istenilen bir anda durdurulması için kullanılır.
            //    }
            //    sonucMetin = sonucMetin + girilenDeger + sonEk;
            //    //100 + 250 +500+
            //    toplam += Convert.ToInt32(girilenDeger);

            //}
            //int alinacakisminUzunlugu = sonucMetin.Length - sonEk.Length;
            //sonucMetin= sonucMetin.Substring(0, alinacakisminUzunlugu);

            //Console.WriteLine($"{sonucMetin} = {toplam}");

            //Soru: 5*5 lik bir kare biçimini * işaretleriyle oluşturan uygulamayı yazınız.
            /*
             * * * * * *
             * * * * * *
             * * * * * *
             * * * * * *
             * * * * * *
             */
            //int satir = 5;
            //int sutun = 5;
            //for (int i = 0; i < satir; i++)
            //{
            //    //A
            //    for (int j = 0; j < sutun; j++)
            //    {
            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}           

            //Soru: 5*5'lik bir içi boş kare biçimini * işaretleriyle oluşturan uygulamayı yazınız.
            //******
            //*    *
            //*    *
            //*    *
            //******


            int satir = 5;
            int sutun = 5;
            for (int i = 1; i <= satir; i++)
            {
                //a
                for (int j = 1; j <= sutun; j++)
                {
                    if (i==1 || i== satir) // eğer 1. veya son satırdaysan
                    {
                        Console.WriteLine("*");
                    }
                    else if (j==1 || j== sutun) //eğer 1. veya son sütündaysan
                    {
                        Console.WriteLine("*");
                    }
                    else
                    {
                        Console.WriteLine("");
                    }                   
                }
                Console.WriteLine();
            }
             // ÖDEV: üstteki içi boş kareyi oluşturan uygulamayı adım adım çalıştırarak anlamaya çalışınız.
             // ÖDEV-1: 1-100 arasındaki sayıların ortalamasını bulduran program
             // ÖDEV-2: 1-100 arasındaki çift, tek ve 5 in katı olan sayıların adetleri ve toplamlarını ekrana yazdıran program
             // ÖDEV-3: Aşağıdaki yüksekliği 5, tabanı 9 birim olan yıldızlardan oluşan dik üçgeni çizdiren program.

            /*
             * *
             * ***
             * *****
             * *******
             * *********
             */
            
            

        }
    }
}