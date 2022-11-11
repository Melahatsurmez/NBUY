using System.Data.SqlClient;
using Proje05_KatmanliMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanliMimari.DataAccessLayer
{

    public class SqlCustomerDAL : ICustomerDAL
    {
        private SqlConnection GetSqlConnection()
        {
            string connectionString = "Server=DESKTOP-OFVK2FD; Database=Northwind; User=sa; Pwd=123";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
        public void Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    string queryString = "SELECT CustomerID,CompanyName,City,Country FROM Customers";
                    SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        customers.Add(new Customer()
                        {
                            Id = sqlDataReader["CustomerID"].ToString(),
                            Company = sqlDataReader["CompanyName"].ToString(),
                            City = sqlDataReader["City"].ToString(),
                            Country = sqlDataReader["Country"].ToString()
                        });
                    }
                    sqlDataReader.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir sorun oluştu!");
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

        public List<Customer> GetCustomersByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public void UpdateCostumer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}