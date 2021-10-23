using Application.DTOs.Product;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdventureWorksAPI.Controllers
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

        [HttpGet("", Name = "GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _productService.FindAllAsync());
        }

        [HttpGet("{productID:int}", Name = "GetByProductId")]
        public async Task<IActionResult> GetByProductIdAsync([FromRoute] int productID)
        {
            return Ok(await _productService.FindAsync(productID));
        }

        [HttpPost("", Name = "CreateProduct")]
        public async Task<IActionResult> CreateProductAsync([FromBody] ProductPostDTO product)
        {
            return Ok(await _productService.InsertAsync(product));
        }

        [HttpPut("", Name = "UpdateProduct")]
        public async Task<IActionResult> UpdateProductAsync([FromBody] ProductPutDTO product)
        {
            return Ok(await _productService.EditAsync(product));
        }

        [HttpDelete("{productID:int}", Name = "DeleteProduct")]
        public async Task<IActionResult> DeleteProductAsync([FromBody] int productID)
        {
            return Ok(await _productService.DeleteAsync(productID));
        }
    }
}