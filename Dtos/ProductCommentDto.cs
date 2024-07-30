using System;

namespace Andromeda.Dtos
{
    public class ProductCommentDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
