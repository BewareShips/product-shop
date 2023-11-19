using shopBackend.Models;
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
        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Product GetProductById(int id)
        {   return _productRepository.GetById(id);
        }
        public void CreateProduct(Product product, UserRole role)
        {
            if(role != UserRole.Admin)
            {
                throw new UnauthorizedAccessException("Only administrators can add products");
            }

            ValidateProduct(product);
            if(_productRepository.GetAll().Any(p =>p.Name == product.Name))
            {
                throw new Exception("A product with this name already exist");
            }
            _productRepository.Add(product);
        }
        public void UpdateProduct(Product product, UserRole role)
        {
            if(role != UserRole.Admin)
            {
                throw new UnauthorizedAccessException("Only administrators can update products.");
            }
            var existingProduct = _productRepository.GetById(product.Id);
            if (existingProduct == null)
            {
                throw new KeyNotFoundException("Product not found.");
            }
            ValidateProduct(product);
            
           

            _productRepository.Update(product);
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
