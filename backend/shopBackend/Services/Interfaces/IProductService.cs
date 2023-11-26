using shopBackend.Models;
using shopBackend.Models.Dto;
using shopBackend.Models.Enums;

namespace shopBackend.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync();
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int id);
        Task CreateProductAsync(ProductDto product, UserRole role);
        Task UpdateProductAsync(ProductDto product, UserRole role);
        Task DeleteProductAsync(int id, UserRole role);
        Task UpdateStockQuantityAsync(int productId, decimal quantity);
    }
}
