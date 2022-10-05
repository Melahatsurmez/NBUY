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
            int ciftToplam = 0;
            int tekToplam = 0;
            for (int i = 1; i <= 10; i = i++)
            {
                if (i % 2 =/ 0)
                {
                    ciftToplam = ciftToplam + i;
                }
                else
                {
                    tekToplam = tekToplam + i;
                }
               
            }
            Console.WriteLine(toplam);

        }
    }
}