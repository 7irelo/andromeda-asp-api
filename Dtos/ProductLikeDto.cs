using System;

namespace Andromeda.Dtos
{
    public class ProductLikeDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
