namespace Proje06_Inharitance_Kalitim_Miras
{
    class Person//bir class istenildigi kadar başka classa miras verilebilir.
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual void Intro() // virtual keyword bu metodun miras alınan classlarda override edilmesine izin verir.
        {
            Console.WriteLine($"First Name: {this.FirstName}, LastName: {this.LastName}");
        }
    }
    class Writer : Person
    {
        public string BookName { get; set; }
    }
    class Teacher : Person
    {
        public string Branch { get; set; }
    }
    class Student : Person //persondsn firstanem ve lastname i alacagı için tekrar yazmamıza gerek kalmıyor //bir class sadecetek bir classtan miras alabilir.
    {
        public int StudentNumber { get; set; }
        public override void Intro() // Bu metodun miras alınan sınıftaki versiyonunu ezip, yok sayıp yerine bu metodu kabul eder.
        {
            Console.WriteLine($"First Name: {this.FirstName}, LastName: {this.LastName}, StudentNamber={this.StudentNumber}");
        }
    }
    class a
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
    }
    class b : a
    {
        public int MyProperty3 { get; set; }
        public int MyProperty4 { get; set; }
    }
    class c : b
    {
        public int MyProperty5 { get; set; }
        public int MyProperty6 { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Student student = new Student();
            student.FirstName = "Kemal";
            student.LastName = "Kapucu";
            student.StudentNumber = 125;
            student.Intro();

            Teacher teacher = new Teacher()
            {
                FirstName = "Alican",
                LastName = "kuloğlu",
                Branch = "Soft Development",
            };
            teacher.Intro();


            Person person1 = new Student();
            
            Console.ReadLine();
            
        }
    }
}