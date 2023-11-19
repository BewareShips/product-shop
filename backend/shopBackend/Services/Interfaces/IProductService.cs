using shopBackend.Models;
using shopBackend.Models.Enums;

namespace shopBackend.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        void CreateProduct(Product product, UserRole role);
        void UpdateProduct(Product product, UserRole role);
        void DeleteProduct(int id, UserRole role);
    }
}
