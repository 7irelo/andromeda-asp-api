using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Andromeda.Models;
using Andromeda.Services;

namespace Andromeda.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductLikeController : ControllerBase
    {
        private readonly IProductLikeService _productLikeService;

        public ProductLikeController(IProductLikeService productLikeService)
        {
            _productLikeService = productLikeService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductLike>> GetAll()
        {
            var productLikes = _productLikeService.GetAll();
            return Ok(productLikes);
        }

        [HttpGet("{id}")]
        public ActionResult<ProductLike> GetById(int id)
        {
            var productLike = _productLikeService.GetById(id);
            if (productLike == null)
                return NotFound();

            return Ok(productLike);
        }

        [HttpPost]
        public ActionResult<ProductLike> Create(ProductLike productLike)
        {
            _productLikeService.Create(productLike);
            return CreatedAtAction(nameof(GetById), new { id = productLike.Id }, productLike);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ProductLike productLike)
        {
            if (id != productLike.Id)
                return BadRequest();

            _productLikeService.Update(productLike);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productLikeService.Delete(id);
            return NoContent();
        }
    }
}
