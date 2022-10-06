namespace Proje12_While;
class Program
{
    static void Main(string[] args)
    {
        
        
        {   
           
           
            // int sayac=1;
            // while (sayac<=5) // Döngü için kullanılır. Doğru oldugu sürece çalışmaya devam eder.
            // {
            //     Console.WriteLine("Hello, World!");
            //     sayac++;
            // }  

            // int toplam=0;
            // string girilenDeger="";
            // int sayac=1;
            // while (girilenDeger !="exit")
            // {
            //     System.Console.Write($"{sayac}. sayıyı giriniz(Çıkış için exit):" );
            //     girilenDeger=Console.ReadLine();
            //     //if (girilenDeger!="exit") toplam +=Convert.ToInt32(girilenDeger); sayac++;    
            //     try
            //     {
            //         toplam +=Convert.ToInt32(girilenDeger);
            //     }
            //     catch (System.Exception)
            //     {
            //         System.Console.WriteLine(toplam);
            //         break;
            //     }    
            //     sayac++;    

         //SORU: Klavyeden exit yazılana kadar isim girilen bir uygulama.

            // string isim="";
            // while (isim!= "exit")
            // {
            //     System.Console.WriteLine("İsim giriniz: ");
            //     isim= System.Console.ReadLine();
            // }
            // System.Console.WriteLine("Program sona erdi...");

            // Çözüm-2

            // string isim;
            // do
            // {
            //     System.Console.Write("İsim giriniz: ");
            //     isim=System.Console.ReadLine();
            // } while (isim!= "exit");
            // System.Console.WriteLine("Program sona erdi...");

            // string girilenDeger;
            // int sayac=1;
            // int toplam = 0;

            // do
            // {
            //     System.Console.WriteLine($"{sayac}. sayıyı giriniz: ");
            //     girilenDeger= Console.ReadLine();
            //     if (girilenDeger!="exit") toplam += Convert.ToInt32(girilenDeger);
            // } while (girilenDeger!="exit");

            // Random rastgele = new Random();    // rastgele değer
            // int rastgeleSayi= rastgele.Next();
            // System.Console.WriteLine(rastgeleSayi);
            // int rastgeleSayi2= rastgele.Next(100); // 100 dahil değildir.0 dahildir.
            // System.Console.WriteLine(rastgeleSayi2);
            // int rastgeleSayı3= rastgele.Next(1000,2000); //1000 dahil 2000 dahil değil
            // System.Console.WriteLine(rastgeleSayı3);


            //OYUN: Uygulamanın rastgele üreteceği bir sayıyı kullanıcının tahmin etmesini isteyeceğiz.
            //Rastgele retilecek sayı 1-11 arasındadır.
            //Kullanıcı rastgele sayıdan büyük yada küçük bir sayı girdiğinde uygun mesaj çıkar.
            //Doğru sayıyı tahmin edene kadar devam etsin.(X)
            // Kullanıcı doğru sayıyı tahmin ettiyse ya da 5 hakkını kullandıysa uygulama sona ersin.

            // Random rnd= new Random();
            // int uretilenSayi= rnd.Next(1,101);
            // System.Console.WriteLine($"HİLE:{uretilenSayi}");
            // System.Console.WriteLine("*************");
            // int tahminEdilenSayi;

            // do
            // {
            //     System.Console.WriteLine("Tahmininizi giriniz(1-100): ");
            //     tahminEdilenSayi= Convert.ToInt32(Console.ReadLine());
            //     if (tahminEdilenSayi>uretilenSayi)
            //     {
            //         System.Console.WriteLine("Büyük bir sayı girdiniz, daha küçük bir sayı giriniz.");
            //     }
            //     else if (tahminEdilenSayi<uretilenSayi)
            //     {
            //         System.Console.WriteLine("Küçük bir sayı girdiniz, daha büyük bir sayı giriniz.");
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("Tebrikler bildiniz.");
            //     }
            // } while (tahminEdilenSayi!=uretilenSayi);

            Random rnd= new Random();
            int uretilenSayi= rnd.Next(1,101);
            System.Console.WriteLine($"HİLE:{uretilenSayi}");
            System.Console.WriteLine("*************");
            int tahminEdilenSayi;
            int hak=1; // Kullanıcının o sırada kaçıncı hakkını kullandıgı bilgisi 
            int hakSiniri=5; // Kullanıcnın toplam kaç hakka sahip oldugu bilgisi

            // do
            // {
            //     System.Console.Write($"{hak}.Tahmininizi giriniz(1-100): ");
            //     tahminEdilenSayi= Convert.ToInt32(Console.ReadLine());
                
            //         if (hak==hakSiniri && uretilenSayi!= tahminEdilenSayi)
            //         {
            //             System.Console.WriteLine("KAYBETTİNİZ");
            //             break;
            //         }
            //         if (tahminEdilenSayi>uretilenSayi)
            //         {
            //             System.Console.WriteLine("Büyük bir sayı girdiniz, daha küçük bir sayı giriniz.");
            //         }
            //         else if (tahminEdilenSayi<uretilenSayi)
            //         {
            //             System.Console.WriteLine("Küçük bir sayı girdiniz, daha büyük bir sayı giriniz.");
            //         }
            //         else
            //         {
            //             System.Console.WriteLine("Tebrikler");
            //         }
            //         hak++;
                 
               
            // } while (tahminEdilenSayi!=uretilenSayi && hak<=hakSiniri);; 
            

            do
            {
                System.Console.Write($"{hak}.Tahmininizi giriniz(1-100): ");
                tahminEdilenSayi= Convert.ToInt32(Console.ReadLine());
                if (tahminEdilenSayi> uretilenSayi)
                {
                    System.Console.WriteLine("büyük girdiniz.");
                }
                else if (tahminEdilenSayi> uretilenSayi)
                {
                    System.Console.WriteLine(" küçük girdiniz.");
                }
                if (tahminEdilenSayi!= uretilenSayi)
                {
                    hak++;
                    if (hak<hakSiniri)
                    {
                        System.Console.WriteLine("kaybettin!");
                    }
                }
                else
                {
                    System.Console.WriteLine("Kazandın!");
                }
            } while (tahminEdilenSayi!= uretilenSayi && hak<=hakSiniri);
            // eğer program bu satıra gelmişse ya doğru tahminde bulunmuştur ya da hak sona ermiştir.
        } 


        
    }
}
