using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Andromeda.Models;
using Andromeda.Services;

namespace Andromeda.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Notification>> GetAll()
        {
            var notifications = _notificationService.GetAll();
            return Ok(notifications);
        }

        [HttpGet("{id}")]
        public ActionResult<Notification> GetById(int id)
        {
            var notification = _notificationService.GetById(id);
            if (notification == null)
                return NotFound();

            return Ok(notification);
        }

        [HttpPost]
        public ActionResult<Notification> Create(Notification notification)
        {
            _notificationService.Create(notification);
            return CreatedAtAction(nameof(GetById), new { id = notification.Id }, notification);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Notification notification)
        {
            if (id != notification.Id)
                return BadRequest();

            _notificationService.Update(notification);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _notificationService.Delete(id);
            return NoContent();
        }
    }
}
