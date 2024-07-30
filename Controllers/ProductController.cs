using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Andromeda.Models;
using Andromeda.Services;

namespace Andromeda.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            var products = _productService.GetAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetById(int id)
        {
            var product = _productService.GetById(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public ActionResult<Product> Create(Product product)
        {
            _productService.Create(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Product product)
        {
            if (id != product.Id)
                return BadRequest();

            _productService.Update(product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return NoContent();
        }
    }
}
