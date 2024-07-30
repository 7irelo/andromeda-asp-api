using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Andromeda.Models
{
    public class Chat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        public int FriendId { get; set; }
        [ForeignKey("FriendId")]
        public User Friend { get; set; }

        public DateTime CreatedAt { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}
