using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Andromeda.Models;
using Andromeda.Services;

namespace Andromeda.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Chat>> GetAll()
        {
            var chats = _chatService.GetAll();
            return Ok(chats);
        }

        [HttpGet("{id}")]
        public ActionResult<Chat> GetById(int id)
        {
            var chat = _chatService.GetById(id);
            if (chat == null)
                return NotFound();

            return Ok(chat);
        }

        [HttpPost]
        public ActionResult<Chat> Create(Chat chat)
        {
            _chatService.Create(chat);
            return CreatedAtAction(nameof(GetById), new { id = chat.Id }, chat);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Chat chat)
        {
            if (id != chat.Id)
                return BadRequest();

            _chatService.Update(chat);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _chatService.Delete(id);
            return NoContent();
        }
    }
}
