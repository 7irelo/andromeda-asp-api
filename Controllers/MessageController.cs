using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Andromeda.Models;
using Andromeda.Services;

namespace Andromeda.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Message>> GetAll()
        {
            var messages = _messageService.GetAll();
            return Ok(messages);
        }

        [HttpGet("{id}")]
        public ActionResult<Message> GetById(int id)
        {
            var message = _messageService.GetById(id);
            if (message == null)
                return NotFound();

            return Ok(message);
        }

        [HttpPost]
        public ActionResult<Message> Create(Message message)
        {
            _messageService.Create(message);
            return CreatedAtAction(nameof(GetById), new { id = message.Id }, message);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Message message)
        {
            if (id != message.Id)
                return BadRequest();

            _messageService.Update(message);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _messageService.Delete(id);
            return NoContent();
        }
    }
}
