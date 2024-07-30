using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Andromeda.Models;
using Andromeda.Services;

namespace Andromeda.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Comment>> GetAll()
        {
            var comments = _commentService.GetAll();
            return Ok(comments);
        }

        [HttpGet("{id}")]
        public ActionResult<Comment> GetById(int id)
        {
            var comment = _commentService.GetById(id);
            if (comment == null)
                return NotFound();

            return Ok(comment);
        }

        [HttpPost]
        public ActionResult<Comment> Create(Comment comment)
        {
            _commentService.Create(comment);
            return CreatedAtAction(nameof(GetById), new { id = comment.Id }, comment);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Comment comment)
        {
            if (id != comment.Id)
                return BadRequest();

            _commentService.Update(comment);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _commentService.Delete(id);
            return NoContent();
        }
    }
}
