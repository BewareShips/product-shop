using shopBackend.Models;
using shopBackend.Models.Dto;
using shopBackend.Models.Enums;

namespace shopBackend.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetAllProducts();
        ProductDto GetProductById(int id);
        void CreateProduct(ProductDto product, UserRole role);
        void UpdateProduct(ProductDto product, UserRole role);
        void DeleteProduct(int id, UserRole role);
        void UpdateStockQuantity(int productId, decimal quantity);
    }
}
