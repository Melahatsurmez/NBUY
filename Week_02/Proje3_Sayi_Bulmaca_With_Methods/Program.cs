namespace Proje3_Sayi_Bulmaca_With_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sayı bulmaca oyununu yeni öğrendiğmiz methods konusu bağlamında yeniden hazırlayınız.
            /*
             * 5 tercih hakkı olsun
             * Puan sistemi olsun (1 tercihte bildiyse 50, bimediyse 10'ar 10'ar düşsün.)
             * Oyunu kaybettiğinde ya da kazandığında Yeniden Oynamak İstiyor ise Oynayabilsin!
             */

            string tercih;
            do
            {
                Console.Clear();
                OYUN.Oyna();
                do
                {
                    //Console.Clear();
                    Console.Write("Yeniden oynamak ister misiniz?[E/H]");
                    tercih = Console.ReadLine().ToUpper();
                } while (tercih != "H" || tercih != "E");
            } while (tercih != "H");
            Console.ReadLine();
        }
    }
}