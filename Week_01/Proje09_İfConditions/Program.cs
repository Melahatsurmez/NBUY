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
            int sayı = Convert.ToInt32(Console.ReadLine());
            if(sayı>=0)
            {
                Console.WriteLine("Merhaba dünya!"); 
            }
        }
    }
}