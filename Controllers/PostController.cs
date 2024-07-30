using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Andromeda.Models;
using Andromeda.Services;

namespace Andromeda.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Post>> GetAll()
        {
            var posts = _postService.GetAll();
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public ActionResult<Post> GetById(int id)
        {
            var post = _postService.GetById(id);
            if (post == null)
                return NotFound();

            return Ok(post);
        }

        [HttpPost]
        public ActionResult<Post> Create(Post post)
        {
            _postService.Create(post);
            return CreatedAtAction(nameof(GetById), new { id = post.Id }, post);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Post post)
        {
            if (id != post.Id)
                return BadRequest();

            _postService.Update(post);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _postService.Delete(id);
            return NoContent();
        }
    }
}
