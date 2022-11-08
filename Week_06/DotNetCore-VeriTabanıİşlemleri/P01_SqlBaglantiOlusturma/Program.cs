using System.Data.SqlClient;

namespace P01_SqlBaglantiOlusturma;
class Program
{
    static void Main(string[] args)
    {
        GetSqlConnection();
        
    }
    static void GetSqlConnection()
    {
        /*1.adım
            ConnectionString oluşturmak
        */
        string connectionString = "Server=DESKTOP-OFVK2FD; Database=Northwind; User Id=sa; Password=123";
        using (var connection=new SqlConnection(connectionString))
        {
            //Conneciton nesnesi sadece bu scope içinde yaşayıp,scope bitişinde bellekten kaldırılmış olucak.
            try
            {
                connection.Open();
                Console.WriteLine("Bağlantı sağlandı...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        
    }
}
