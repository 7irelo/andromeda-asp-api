using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Andromeda.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Avatar { get; set; } = "avatars/profile.png";

        public string Bio { get; set; }

        public ICollection<Friendship> Friendships { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
