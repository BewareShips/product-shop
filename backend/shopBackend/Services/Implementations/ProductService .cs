using shopBackend.Models;
using shopBackend.Models.Dto;
using shopBackend.Models.Enums;
using shopBackend.Repository.Interfaces;
using shopBackend.Services.Interfaces;

namespace shopBackend.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        private readonly List<Category> _categories = new List<Category>
        {
            new Category { Id = 1, Name = "Biscuits" },
            new Category { Id = 2, Name = "Cakes" },
            new Category { Id = 3, Name = "Vegetables" },
            new Category { Id = 4, Name = "Fruits" },
            new Category { Id = 5, Name = "Dairy" },
            new Category { Id = 6, Name = "Beverages" },
            new Category { Id = 7, Name = "Snacks" },
            new Category { Id = 8, Name = "Bakery" },
            new Category { Id = 9, Name = "Meat" },
            new Category { Id = 10, Name = "Seafood" }
        };

        public async Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync()
        {
            return _categories.Select(c => new CategoryDto { Id = c.Id, Name = c.Name }).ToList();
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return products.Select(product => new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                StockQuantity = product.StockQuantity,
                CategoryId = product.CategoryId,
                UnitType = product.UnitType
            }).ToList();
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                StockQuantity = product.StockQuantity,
                CategoryId = product.CategoryId,
                UnitType = product.UnitType
            };
        }

        public async Task CreateProductAsync(ProductDto productDto, UserRole role)
        {
            if (role != UserRole.Admin)
            {
                throw new UnauthorizedAccessException("Only administrators can add products");
            }

            var product = new Product
            {
                Name = productDto.Name,
                Description = productDto.Description,
                Price = productDto.Price,
                StockQuantity = productDto.StockQuantity,
                CategoryId = productDto.CategoryId,
                UnitType = productDto.UnitType
            };
            ValidateProduct(product);
            if ((await _productRepository.GetAllAsync()).Any(p => p.Name == product.Name))
            {
                throw new Exception("A product with this name already exists");
            }
            await _productRepository.AddAsync(product);
        }

        public async Task UpdateProductAsync(ProductDto productDto, UserRole role)
        {
            if (role != UserRole.Admin)
            {
                throw new UnauthorizedAccessException("Only administrators can update products.");
            }

            var existingProduct = await _productRepository.GetByIdAsync(productDto.Id);
            existingProduct.Name = productDto.Name;
            existingProduct.Description = productDto.Description;
            existingProduct.Price = productDto.Price;
            existingProduct.StockQuantity = productDto.StockQuantity;
            existingProduct.CategoryId = productDto.CategoryId;
            existingProduct.UnitType = productDto.UnitType;

            ValidateProduct(existingProduct);
            await _productRepository.UpdateAsync(existingProduct);
        }

        public async Task DeleteProductAsync(int id, UserRole role)
        {
            if (role != UserRole.Admin)
            {
                throw new UnauthorizedAccessException("Only administrators can delete products.");
            }
            var existingProduct = await _productRepository.GetByIdAsync(id);
            await _productRepository.DeleteAsync(id);
        }

        public async Task UpdateStockQuantityAsync(int productId, decimal quantity)
        {
            var product = await _productRepository.GetByIdAsync(productId);
            if (product == null)
            {
                throw new KeyNotFoundException("Product not found.");
            }

            if (product.UnitType == UnitTypeEnum.Piece)
            {
                product.StockQuantity += (int)quantity;
            }
            else if (product.UnitType == UnitTypeEnum.Kilogram)
            {
                product.StockQuantity += (int)Math.Round(quantity);
            }

            await _productRepository.UpdateAsync(product);
        }

        private void ValidateProduct(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
            {
                throw new ArgumentException("Product name is required.");
            }

            if (product.Price <= 0)
            {
                throw new ArgumentException("Price must be greater than zero.");
            }

            if (product.StockQuantity < 0)
            {
                throw new ArgumentException("Stock cannot be negative.");
            }

            if (string.IsNullOrWhiteSpace(product.Description))
            {
                throw new ArgumentException("Product description is required.");
            }

            if (product.CategoryId <= 0)
            {
                throw new ArgumentException("Category ID must be a positive number.");
            }
        }

    }
}
