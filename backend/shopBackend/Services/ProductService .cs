using shopBackend.Models;
using shopBackend.Models.Dto;
using shopBackend.Models.Enums;
using shopBackend.Repository.Interfaces;
using shopBackend.Services.Interfaces;

namespace shopBackend.Services
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

        public IEnumerable<CategoryDto> GetAllCategories()
        {
            return _categories.Select(c => new CategoryDto { Id = c.Id, Name = c.Name }).ToList();
        }
        public IEnumerable<ProductDto> GetAllProducts()
        {
            var products = _productRepository.GetAll();
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

        public ProductDto GetProductById(int id)
        {
            var product = _productRepository.GetById(id);
            if (product == null)
            {
                throw new KeyNotFoundException("Product not found.");
            }
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
        public void CreateProduct(ProductDto productDto, UserRole role)
        {
            if(role != UserRole.Admin)
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
            if(_productRepository.GetAll().Any(p =>p.Name == product.Name))
            {
                throw new Exception("A product with this name already exist");
            }
            _productRepository.Add(product);
        }
        public void UpdateProduct(ProductDto productDto, UserRole role)
        {
            if (role != UserRole.Admin)
            {
                throw new UnauthorizedAccessException("Only administrators can update products.");
            }

            var existingProduct = _productRepository.GetById(productDto.Id);
            if (existingProduct == null)
            {
                throw new KeyNotFoundException("Product not found.");
            }

            existingProduct.Name = productDto.Name;
            existingProduct.Description = productDto.Description;
            existingProduct.Price = productDto.Price;
            existingProduct.StockQuantity = productDto.StockQuantity;
            existingProduct.CategoryId = productDto.CategoryId;
            existingProduct.UnitType = productDto.UnitType;

            ValidateProduct(existingProduct);
            _productRepository.Update(existingProduct);
        }

        public void DeleteProduct(int id, UserRole role)
        {
           if(role != UserRole.Admin)
            {
                throw new UnauthorizedAccessException("Only administrators can delete products.");
            }
           var existingProduct = GetProductById(id);
            if (existingProduct == null)
            {
                throw new KeyNotFoundException("Product not found.");
            }

            _productRepository.Delete(id);

        }
        public  void UpdateStockQuantity(int productId, decimal quantity)
        {
            var product = _productRepository.GetById(productId);
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

             _productRepository.Update(product);
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
