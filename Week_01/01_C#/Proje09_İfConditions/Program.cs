namespace Proje09_İfConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * if(bool)
             * {
             *     bool true ise yapılacak işler
             *     
             * }
             */
            //int sayı = Convert.ToInt32(Console.ReadLine());
            //if(sayı>=0)
            //{
            //    Console.WriteLine("Merhaba dünya!"); 
            //}

            //Kullanıcıdan yaşını girmesini isteyelim.
            //18 yaşından küçüklere "GİRİŞ YASAK" yazdıralım.
            //Console.WriteLine("Lütfen yaşınızı giriniz: ");
            //byte yas = Convert.ToByte(Console.ReadLine());
            //if(yas<18)
            //{
            //    Console.WriteLine("GİRİŞ YASAK");
            //}
            //else if(yas>18)
            //{
            //    Console.WriteLine("GİRİŞ SERBEST");
            //}
            //else
            //{
            //    Console.WriteLine("Velinle birlikte gel!");
            //}

            //Girilen iki sayıdan büyük olanı yazdıralım
            //Console.Write("1.Sayıyı gir: ");
            //int sayı1= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayıyı gir: ");
            //int sayı2= Convert.ToInt32(Console.ReadLine());
            //if(sayı1>sayı2)
            //{
            //    Console.WriteLine($"Sayı 1({sayı1}) ve sayı 2({sayı2})birbirine eşittir");
            //}   
            //else if(sayı2>sayı1)
            //{
            //    Console.WriteLine($"Büyük sayı:{sayı1}");
            //}
            //else
            //{
            //    Console.WriteLine($"Sayı 1({sayı1}) ve Sayı 2({sayı2}) birbirlerine eşittir!");
            //}

            //Girilen 3 sayıdan büyük olanı yazalım

            //Console.Write("1.Sayıyı gir: ");
            //int sayı1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.Sayıyı gir: ");
            //int sayı2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("3.Sayıyı gir: ");
            //int sayı3 = Convert.ToInt32(Console.ReadLine());

            //if (sayı1>=sayı2 && sayı2>=sayı3) //shift 66 ile && yapılır ve anlamına gelir.
            //{
            //    Console.WriteLine(sayı1);
            //}
            //else if(sayı2>=sayı1 && sayı2>=sayı3)
            //{
            //    Console.WriteLine(sayı2);
            //}
            //else if (sayı3>=sayı1 && sayı3>=sayı2)
            //{
            //    Console.WriteLine(sayı3);
            //}

            // bu doğru olmayan bir algoritma
            //if(sayı1>sayı2)
            //{
            //    if (sayı1>sayı3)
            //    {
            //        Console.WriteLine(sayı1);
            //    }
            //}
            //else if (sayı2>sayı1)
            //{
            //    if (sayı2>sayı3)
            //    {

            //    }
            //}

            Console.Write("1.Sayıyı gir: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı gir: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            string sonuc = sayi1 > sayi2 ? "1. Sayı 2. Sayıdan büyüktür." :
                                    sayi2 > sayi1 ? "2. Sayı 1.Sayıdan büyüktür." :
                                            "İki sayı birbirine eşittir.";
            Console.WriteLine(sonuc);

            //int buyukSayi = sayı1 > sayı2 ? sayı1 : sayı2; //kısa yol
            //Console.WriteLine(buyukSayi);

            
            //int buyukSayi = 0;
            //if (sayı1 > sayı2)
            //{
            //    buyukSayi = sayı1;
            //}
            //else if (sayı2>sayı1)
            //{
            //    buyukSayi = sayı2;
            //}
            ////else
            ////{
            ////    buyukSayi = sayı2;
            ////}
            //Console.WriteLine(buyukSayi);


        }
    }
}