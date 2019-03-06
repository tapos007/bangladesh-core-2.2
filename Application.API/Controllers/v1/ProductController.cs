using Application.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Application.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        /// <summary>
        /// Get all product.
        /// </summary>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ProductHelper.Get());
        }

        /// <summary>
        /// Get a product.
        /// </summary>
        /// <param name="id"></param> 
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return Ok(ProductHelper.GetAProduct(id));
        }

        /// <summary>
        /// Creates a TodoItem.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Product
        ///     {
        ///        "name": "Item1",
        ///        "description": "good book:
        ///     }
        ///
        /// </remarks>
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            return Ok(ProductHelper.AddProduct(product));
        }

        /// <summary>
        /// Update a specific TodoItem.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="product"></param> 
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Product product)
        {
            return Ok(ProductHelper.Update(id,product));
        }

        /// <summary>
        /// Deletes a specific Product.
        /// </summary>
        /// <param name="id"></param> 
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(ProductHelper.DeleteProduct(id));
        }
    }
}
