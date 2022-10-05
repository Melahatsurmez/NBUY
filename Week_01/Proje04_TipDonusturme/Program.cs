namespace Proje04_TipDonusturme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte a = 5;
            //short b = 10;
            //sbyte c = 30;
            //int d = a + b + c; //Implicit Convert- Gizli dönüştürme
            ////Console.WriteLine($"Sonuç(d)= {d}");

            //string metin = "NBUY";
            //char karakter = 'k';
            //object e = metin + karakter + d;
            //Console.WriteLine($"Object= {e}"); //Implicit Convert

            //byte a = 155;
            //byte b = 101;
            ///* byte c = Convert.ToByte(a + b); */ // Explicit Convert- Bilinçli Dönüşüm



            // byte d = (byte)(a + b); //Unboxing
            // Console.WriteLine($"Sonuç(d): {d}");


            int a = 256;
            byte b = (byte)a;
            Console.WriteLine(b);

            //byte a = 155;
            //byte b = 101;
            //int c = a + b;
            //Console.WriteLine();


            //  Convert.ToDouble(c);
            //Convert.ToInt64(c);
        }
    }
}