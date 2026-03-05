using Microsoft.AspNetCore.Mvc;
using ShopSphere.API.Models;
using ShopSphere.API.Services;

namespace ShopSphere.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _service.GetProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _service.GetProduct(id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            var result = await _service.CreateProduct(product);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            await _service.UpdateProduct(product);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _service.DeleteProduct(id);
            return Ok();
        }
    }
}