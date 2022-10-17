using System.Collections;

namespace Proje10_Collections_ArrayList
{
    internal class Program
    {
        static void Yazdir(ArrayList arrayList)
        {
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList() { 54, 12, 66, 34, 19 };
            Console.WriteLine("Default Sıra");
            Yazdir(sayilar);
            sayilar.Sort();
            Console.WriteLine("***********");
            Console.WriteLine("Küçükten Büyüğe");
            Yazdir(sayilar);
            sayilar.Sort();
            Console.WriteLine("************");
            Console.WriteLine("Büyükten Küçüğe");
            sayilar.Reverse();
            Yazdir(sayilar);

            
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(sayilar); //aynı
            //}







            //ArrayList myList= new ArrayList();

            //myList.Add(120);
            //myList.Add("120"); // string  oldu.
            //myList.Add("Zeynep");
            //myList.Add(11.5);
            //myList.Add(DateTime.Now);
            //myList.Add(true);

            //myList.Insert(0, "Yeni eleman"); //araya eleman eklemek =insert

            //ArrayList addedList = new ArrayList() { "Ayşen Umay", "Fercan Sercan", "Kazım Kolkanat" };
            //myList.InsertRange(4, addedList); // araya liste şeklinde eklemek= InsertRange
            //myList.AddRange(addedList); // listenin sonuna liste eklemek


            //myList.Remove("Zeynep"); // silme
            ////myList.RemoveAt(0); // kaçıncı elemanı silmek isteiğimiz
            ////myList.RemoveRange(0, 10); // kaçtan kaça silineceği
            //foreach (var item in myList)
            //{
            //    Console.WriteLine(item);
            //}

            //if (myList.Contains("Zeynep")==true)
            //{
            //    Console.WriteLine("Evet Zeynep listede mevcut!");
            //}
            //else
            //{
            //    Console.WriteLine("Acil Zeynep'e haber ver! Listede yok!");
            //}

           
            //Console.WriteLine();
            ////Console.WriteLine(myList[3]);  removerangeden dolayı commitledik

            //Console.ReadLine( );
        }
    }
}