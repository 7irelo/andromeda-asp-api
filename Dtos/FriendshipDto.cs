namespace Andromeda.Dtos
{
    public class FriendshipDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FriendId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
