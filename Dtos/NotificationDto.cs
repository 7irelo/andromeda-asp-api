using System;

namespace Andromeda.Dtos
{
    public class NotificationDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
