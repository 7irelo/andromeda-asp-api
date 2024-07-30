using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Andromeda.Models
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int ChatId { get; set; }
        [ForeignKey("ChatId")]
        public Chat Chat { get; set; }

        [Required]
        public int SenderId { get; set; }
        [ForeignKey("SenderId")]
        public User Sender { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
