using System;

namespace Andromeda.Dtos
{
    public class MessageDto
    {
        public int Id { get; set; }
        public int ChatId { get; set; }
        public int SenderId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
