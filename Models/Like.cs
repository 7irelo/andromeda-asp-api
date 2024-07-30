using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Andromeda.Models
{
    public class Like
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        public int PostId { get; set; }
        [ForeignKey("PostId")]
        public Post Post { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
