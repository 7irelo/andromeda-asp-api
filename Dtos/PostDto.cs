using System;

namespace Andromeda.Dtos
{
    public class PostDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
