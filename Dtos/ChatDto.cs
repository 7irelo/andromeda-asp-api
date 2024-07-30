using System;

namespace Andromeda.Dtos
{
    public class ChatDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FriendId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
