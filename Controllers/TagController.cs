using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Andromeda.Models;
using Andromeda.Services;

namespace Andromeda.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TagController : ControllerBase
    {
        private readonly ITagService _tagService;

        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Tag>> GetAll()
        {
            var tags = _tagService.GetAll();
            return Ok(tags);
        }

        [HttpGet("{name}")]
        public ActionResult<Tag> GetByName(string name)
        {
            var tag = _tagService.GetByName(name);
            if (tag == null)
                return NotFound();

            return Ok(tag);
        }

        [HttpPost]
        public ActionResult<Tag> Create(Tag tag)
        {
            _tagService.Create(tag);
            return CreatedAtAction(nameof(GetByName), new { name = tag.Name }, tag);
        }

        [HttpPut("{name}")]
        public IActionResult Update(string name, Tag tag)
        {
            if (name != tag.Name)
                return BadRequest();

            _tagService.Update(tag);
            return NoContent();
        }

        [HttpDelete("{name}")]
        public IActionResult Delete(string name)
        {
            _tagService.Delete(name);
            return NoContent();
        }
    }
}
