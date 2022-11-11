using Proje05_KatmanliMimari.DataAccessLayer;
using Proje05_KatmanliMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanliMimari.BusinessLAyer
{
    public class ProductManager
    {
        private readonly IProductDAL _productDAL;   //bu işlem DEPENDENCY INJECTION
        public ProductManager(IProductDAL productDAL)
        {
            _productDAL= productDAL;
        }                                                   //BURAYA KADAR
       
        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            return _productDAL.GetAllProducts();
        }

        public Product GetByIdProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}