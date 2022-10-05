namespace Proje07_TarihMetotları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Today);

            //DateTime doğumTarihi = new DateTime(1999, 6, 17);
            //DateTime bugun = DateTime.Now;
            //TimeSpan span = bugun.Subtract(doğumTarihi);
            //Console.WriteLine($"Toplam {Math.Floor(span.TotalDays)} gündür yaşıyorsunuz");

            //DateTime bugun = DateTime.Now;
            //Console.WriteLine(bugun.ToLongDateString());// 5 Ekim 2022 çarşamba
            //Console.WriteLine(bugun.ToLongTimeString());//13:35:30
            //Console.WriteLine(bugun.ToShortDateString());//5.10.2022
            //Console.WriteLine(bugun.ToShortTimeString());//13.35


            //// bir ssonraki yılın ilk gününn tarihini bulalım
            //DateTime bugun = DateTime.Now;
            //int yil = bugun.Year + 1;
            //DateTime sonuc = new DateTime(yil, 1, 1);
            //Console.WriteLine(sonuc.ToLongDateString());

            //Bir sonraki ayın ilk gününün tarihini bulalım.

            //DateTime bugun=DateTime.Now;
            //int yil=bugun.Year;
            //int ay = bugun.Month + 1;
            //DateTime sonuc = new DateTime(yil, ay, 1);
            //Console.WriteLine(sonuc);

            DateTime bugun = DateTime.Now;
            //Console.WriteLine(bugun + 1);
            
            //ödev = Ertesi günün tarihini bulup ekraan yazdırınız.
        }
    }
}