using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Andromeda.Models;
using Andromeda.Services;

namespace Andromeda.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductTagController : ControllerBase
    {
        private readonly IProductTagService _productTagService;

        public ProductTagController(IProductTagService productTagService)
        {
            _productTagService = productTagService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductTag>> GetAll()
        {
            var productTags = _productTagService.GetAll();
            return Ok(productTags);
        }

        [HttpGet("{id}")]
        public ActionResult<ProductTag> GetById(int id)
        {
            var productTag = _productTagService.GetById(id);
            if (productTag == null)
                return NotFound();

            return Ok(productTag);
        }

        [HttpPost]
        public ActionResult<ProductTag> Create(ProductTag productTag)
        {
            _productTagService.Create(productTag);
            return CreatedAtAction(nameof(GetById), new { id = productTag.Id }, productTag);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ProductTag productTag)
        {
            if (id != productTag.Id)
                return BadRequest();

            _productTagService.Update(productTag);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productTagService.Delete(id);
            return NoContent();
        }
    }
}
