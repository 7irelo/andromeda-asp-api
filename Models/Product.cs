using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Andromeda.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; }

        public ICollection<ProductLike> ProductLikes { get; set; }
        public ICollection<ProductComment> ProductComments { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; }
    }
}
