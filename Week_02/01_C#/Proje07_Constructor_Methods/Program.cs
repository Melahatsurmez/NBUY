namespace Proje07_Constructor_Methods
{
    class Person
    {
        public Person()//Method , consturctor method - tipi olmaz
        {
            // her classın default olarak boş bir constructor methodu vardır, ama impilcittir, yani örtülü , gizlidir. şu anda biz kendimiz bir constructor method yazdık!
            // constructor method ilgili classtan new keywordu ile yeni bir nesne yaratıldıgı anda çalışacak kodları barındırır. yani bu classtan bir nesne üretildigi anda buradaki kodlar çalışır
            Console.WriteLine("Merhaba ben Person, şu an yaratıldım");
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Student: Person //base miras almak istediği class base class
    {
        public Student(string firstName, string lastName, int studentNumber):base(firstName,lastName) //  base iyazmadanda dene //ctor cnstrc kısaltılmışı
        {
            //FirstName = firstName;
            //LastName = lastName; // base olmadan
            StudentNumber = studentNumber;
        }
        public int StudentNumber { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person();
            //Person person2 = new Person("Melahat", "Sürmez");
            //Console.WriteLine($"{person2.FirstName} {person2.LastName}");
            
            Student student1 = new Student("Ahmet","Can",345);
            Console.WriteLine($"{student1.FirstName} {student1.LastName} {student1.StudentNumber}");

            Console.ReadLine();
        }
    }
}