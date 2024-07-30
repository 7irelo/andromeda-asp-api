using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Andromeda.Models;
using Andromeda.Services;

namespace Andromeda.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LikeController : ControllerBase
    {
        private readonly ILikeService _likeService;

        public LikeController(ILikeService likeService)
        {
            _likeService = likeService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Like>> GetAll()
        {
            var likes = _likeService.GetAll();
            return Ok(likes);
        }

        [HttpGet("{id}")]
        public ActionResult<Like> GetById(int id)
        {
            var like = _likeService.GetById(id);
            if (like == null)
                return NotFound();

            return Ok(like);
        }

        [HttpPost]
        public ActionResult<Like> Create(Like like)
        {
            _likeService.Create(like);
            return CreatedAtAction(nameof(GetById), new { id = like.Id }, like);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Like like)
        {
            if (id != like.Id)
                return BadRequest();

            _likeService.Update(like);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _likeService.Delete(id);
            return NoContent();
        }
    }
}
