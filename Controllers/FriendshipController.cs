using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Andromeda.Models;
using Andromeda.Services;

namespace Andromeda.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FriendshipController : ControllerBase
    {
        private readonly IFriendshipService _friendshipService;

        public FriendshipController(IFriendshipService friendshipService)
        {
            _friendshipService = friendshipService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Friendship>> GetAll()
        {
            var friendships = _friendshipService.GetAll();
            return Ok(friendships);
        }

        [HttpGet("{id}")]
        public ActionResult<Friendship> GetById(int id)
        {
            var friendship = _friendshipService.GetById(id);
            if (friendship == null)
                return NotFound();

            return Ok(friendship);
        }

        [HttpPost]
        public ActionResult<Friendship> Create(Friendship friendship)
        {
            _friendshipService.Create(friendship);
            return CreatedAtAction(nameof(GetById), new { id = friendship.Id }, friendship);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Friendship friendship)
        {
            if (id != friendship.Id)
                return BadRequest();

            _friendshipService.Update(friendship);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _friendshipService.Delete(id);
            return NoContent();
        }
    }
}
