using Application.DTOs.Product;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace AdventureWorksAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Get All Products
        /// </summary>
        /// <returns> Array products </returns>
        [HttpGet("", Name = "GetAllProducts")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200", Type = typeof(IEnumerable<ProductGetDTO>))]
        [SwaggerResponse((int)HttpStatusCode.NotFound, Description = "Missing products object")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _productService.FindAllAsync();

            if (result == null)
            {
                return NotFound(null);
            }

            return Ok(result);
        }

        /// <summary>
        /// Get Product By Id
        /// </summary>
        /// <returns> Product </returns>
        [HttpGet("{productID:int}", Name = "GetByProductId")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200", Type = typeof(ProductGetDTO))]
        [SwaggerResponse((int)HttpStatusCode.NotFound, Description = "Missing product object")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> GetByProductIdAsync([FromRoute] int productID)
        {
            var result = await _productService.FindAsync(productID);

            if (result == null)
            {
                return NotFound(null);
            }

            return Ok(result);
        }

        /// <summary>
        /// Create Product Object
        /// </summary>
        /// <param name="product"> Product Data </param>
        /// <returns> Product </returns>
        [HttpPost("", Name = "CreateProduct")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200", Type = typeof(ProductGetDTO))]
        [SwaggerResponse((int)HttpStatusCode.NotFound, Description = "Missing product object")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> CreateProductAsync([FromBody] ProductPostDTO product)
        {
            var result = await _productService.InsertAsync(product);

            if (result == null)
            {
                return NotFound(null);
            }

            return Ok(result);
        }

        /// <summary>
        /// Update Product Object
        /// </summary>
        /// <param name="product"> Product Data </param>
        /// <returns> bool </returns>
        [HttpPut("", Name = "UpdateProduct")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200", Type = typeof(bool))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> UpdateProductAsync([FromBody] ProductPutDTO product)
        {
            return Ok(await _productService.EditAsync(product));
        }

        /// <summary>
        /// Delete Product Object
        /// </summary>
        /// <param name="productID"> Product Code </param>
        /// <returns> bool </returns>
        [HttpDelete("{productID:int}", Name = "DeleteProduct")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200", Type = typeof(bool))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> DeleteProductAsync([FromBody] int productID)
        {
            return Ok(await _productService.DeleteAsync(productID));
        }
    }
}