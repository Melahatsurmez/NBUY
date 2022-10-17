using System.Collections;

namespace proje04_Sayisal_Loto_Oyunu
{
    internal class Program
    {
        static int[] SayiUret()
        {
            Random rnd = new Random();
            int[] loto = new int[6];
            int sayi;
            return loto;    
            for (int i = 0; i < 6; i++)
            {
                do
                {
                    sayi = rnd.Next(1, 50);
                } while (loto.Contains(sayi)); //while true oldukça çalışmaya devam eder.
                loto[i] = sayi;
            }
        }
        static void Hile(int[] loto)
        {
            #region
            Console.WriteLine("HİLE");
            Console.WriteLine("****");
            foreach (var siradakiSayi in loto)
            {
                Console.WriteLine(siradakiSayi);
            }
            #endregion
        }
        static int TahminYap( int tahminSiraNo)
        {
            int tahmin;
            Console.WriteLine($"{tahminSiraNo}.tahmininizi giriniz: ");
            tahmin = int.Parse(Console.ReadLine());
            return tahmin;
        }//kullanıcının tahminini burası yapacak

        static void Main(string[] args)
        {
            /*
             * Sistem 1-49 arasında 6 tane farklı sayı üretsin
             * Kullanıcıdan 6 tane tahmin alalım
             * Sonuç olarak kullanıcının kaç tane doğru tahmin yazdıgını, tahminleriyle birlikte yazdıralım
             * Not: Hiç doğru tahmin yazamazsa kaybettiniz yazsın.
             */
            int[] loto = SayiUret();
            int[] tahminler= new int[6];
            Hile(loto);
            int tahmin;
            
            for (int i = 0; i < 6; i++)
            {
                do
                {
                    tahmin= TahminYap(i + 1);
                } while (tahmin<0 || tahmin>49);
                tahminler[i] = tahmin;
                
            }
            ArrayList bilinenler = new ArrayList(); // Arraylistlerin kaç elemanlı olacagı söylenmez! içinde her bir eleman istenilen tipte değer tutabilir. int string char gibi
            foreach (var siradakiTahmin in tahminler)
            {
                if (loto.Contains(siradakiTahmin))
                {
                    bilinenler.Add(siradakiTahmin);
                }
            }

            if (bilinenler.Count==0)
            {
                Console.WriteLine("Kaybettiniz, hiç bilemediniz");
            }
            else
            {
                Console.WriteLine($"Tebrikler, {bilinenler.Count} adet doğru tahmin yaptınız!");
                Console.WriteLine("Bildiğiniz sayılar");
            }
            foreach (var siradakiBilinen in bilinenler)
            {
                Console.WriteLine(siradakiBilinen);
            }


            Console.ReadLine();
        }
    }
}