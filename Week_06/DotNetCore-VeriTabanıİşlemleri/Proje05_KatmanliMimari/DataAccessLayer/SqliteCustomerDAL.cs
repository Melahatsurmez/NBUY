using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

using Proje05_KatmanliMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanliMimari.DataAccessLayer
{
    public class SqliteCustomerDAL:ICustumerDAL
    {
        private SqliteConnection GetSqliteConnection(){
            string connectionString="Data Source=northwind.db";
            SqliteConnection sqliteConnection=new SqliteConnection(connectionString);
            return sqliteConnection;
        }

        public void Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
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
    }
}