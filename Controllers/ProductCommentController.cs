using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Andromeda.Models;
using Andromeda.Services;

namespace Andromeda.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductCommentController : ControllerBase
    {
        private readonly IProductCommentService _productCommentService;

        public ProductCommentController(IProductCommentService productCommentService)
        {
            _productCommentService = productCommentService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductComment>> GetAll()
        {
            var productComments = _productCommentService.GetAll();
            return Ok(productComments);
        }

        [HttpGet("{id}")]
        public ActionResult<ProductComment> GetById(int id)
        {
            var productComment = _productCommentService.GetById(id);
            if (productComment == null)
                return NotFound();

            return Ok(productComment);
        }

        [HttpPost]
        public ActionResult<ProductComment> Create(ProductComment productComment)
        {
            _productCommentService.Create(productComment);
            return CreatedAtAction(nameof(GetById), new { id = productComment.Id }, productComment);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ProductComment productComment)
        {
            if (id != productComment.Id)
                return BadRequest();

            _productCommentService.Update(productComment);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productCommentService.Delete(id);
            return NoContent();
        }
    }
}
