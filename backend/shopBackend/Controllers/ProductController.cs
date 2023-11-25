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
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public ActionResult<ProductDto> GetById(int id)
        {
            var product = _productService.GetProductById(id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost]
        public ActionResult Create(ProductDto product, [FromHeader(Name ="Role")] UserRole role)
        {
            try
            {
                _productService.CreateProduct(product, role);
                return CreatedAtAction(nameof(GetById), new { id = product.Id },product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, ProductDto product, [FromHeader(Name = "Role")] UserRole role)
        {
            if (id != product.Id)
            {
                return BadRequest("Product ID mismatch.");
            }
            try
            {
                _productService.UpdateProduct(product, role);
                return Ok($"Product with ID {id} has been updated.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromHeader(Name = "Role")] UserRole role)
        {
            try
            {
                _productService.DeleteProduct(id, role);
                return Ok($"Product with ID {id} has been deleted.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
