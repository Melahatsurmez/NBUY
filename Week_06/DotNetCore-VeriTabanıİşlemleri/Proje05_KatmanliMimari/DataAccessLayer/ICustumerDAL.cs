using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje05_KatmanliMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanliMimari.DataAccessLayer
{
    public interface ICustumerDAL
    {
        void Create(Customer customer);
        List<Customer> GetAllCustomers();
        Customer GetByIdCustomer(int id);
        void UpdateCostumer( Customer customer);
        void DeleteCustomer( int id);
        List<Customer>GetCustomersByCategory( string categoryName);

    }
}