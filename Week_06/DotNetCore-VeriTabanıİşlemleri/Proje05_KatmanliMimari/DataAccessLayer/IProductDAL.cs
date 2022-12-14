using Proje05_KatmanliMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanliMimari.DataAccessLayer
{
    public interface IProductDAL
    {
        void CreateProduct(Product product);    // C-reate
        List<Product> GetAllProducts();         // R-ead
        Product GetByIdProduct(int id);
        void UpdateProduct(Product product);    // U-pdate
        void DeleteProduct(int id);             // D-elete
        List<Product> GetProductsByCategory(string categoryName);
    }
}