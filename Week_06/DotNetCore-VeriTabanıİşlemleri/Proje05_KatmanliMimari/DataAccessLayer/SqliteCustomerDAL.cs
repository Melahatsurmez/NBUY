using Microsoft.Data.Sqlite;

using Proje05_KatmanliMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanliMimari.DataAccessLayer
{
    public class SqliteCustomerDAL:ICustomerDAL
    {
        private SqliteConnection GetSqliteConnection(){
            string connectionString="Data Source=northwind.db";
            SqliteConnection sqliteConnection=new SqliteConnection(connectionString);
            return sqliteConnection;
        }

        public void CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers =new List<Customer>();
            using (var connection=GetSqliteConnection())
            {
                try
                {
                    connection.Open();
                    string queryString="Select CustomerID,CompanyName,City,Country FROM Customers";
                    SqliteCommand sqliteCommand=new SqliteCommand(queryString,connection);
                    SqliteDataReader sqliteDataReader=sqliteCommand.ExecuteReader();
                    while (sqliteDataReader.Read())
                    {
                        customers.Add(new Customer(){
                            Id = sqliteDataReader["CustomerID"].ToString(),
                            Company = sqliteDataReader["CompanyName"].ToString(),
                            City = sqliteDataReader["City"].ToString(),
                            Country = sqliteDataReader["Country"].ToString()
                        });
                    }
                    sqliteDataReader.Close();
                }
                catch(System.Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return customers;
        }

        public Customer GetByIdCustomer(int id)
        {
            throw new NotImplementedException();
        }
        
        public void UpdateCostumer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomersByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public void Create(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}