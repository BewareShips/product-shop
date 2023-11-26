using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shopBackend.Models;
using shopBackend.Models.Dto;
using shopBackend.Models.Enums;
using shopBackend.Services.Interfaces;

namespace shopBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("AllProducts")]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }
        [HttpGet("AllCategories")]
        public async Task <ActionResult<IEnumerable<CategoryDto>>> GetAllCategories()
        {
            var categories = await _productService.GetAllCategoriesAsync();
            return Ok(categories);
        }
        [HttpGet("{id}")]
        public async Task <ActionResult<ProductDto>> GetById(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost]
        public async Task <ActionResult> Create(ProductDto product, [FromHeader(Name ="Role")] UserRole role)
        {
            try
            {
               await _productService.CreateProductAsync(product, role);
                return CreatedAtAction(nameof(GetById), new { id = product.Id },product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public async Task <IActionResult> Update(int id, ProductDto product, [FromHeader(Name = "Role")] UserRole role)
        {
            if (id != product.Id)
            {
                return BadRequest("Product ID mismatch.");
            }
            try
            {
                await _productService.UpdateProductAsync(product, role);
                return Ok($"Product with ID {id} has been updated.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task <IActionResult> Delete(int id, [FromHeader(Name = "Role")] UserRole role)
        {
            try
            {
                await _productService.DeleteProductAsync(id, role);
                return Ok($"Product with ID {id} has been deleted.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
