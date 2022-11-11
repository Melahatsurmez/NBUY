using Proje05_KatmanliMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanliMimari.DataAccessLayer
{
    public interface ICustomerDAL
    {
        void Create(Customer customer);
        List<Customer> GetAllCustomers();
        Customer GetByIdCustomer(int id);
        void UpdateCostumer( Customer customer);
        void DeleteCustomer( int id);
        List<Customer>GetCustomersByCategory( string categoryName);

    }
}