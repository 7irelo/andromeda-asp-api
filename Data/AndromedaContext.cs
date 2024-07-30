using Microsoft.EntityFrameworkCore;
using Andromeda.Models;

namespace Andromeda.Data
{
    public class AndromedaContext : DbContext
    {
        public AndromedaContext(DbContextOptions<AndromedaContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductLike> ProductLikes { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
