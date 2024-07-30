using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Andromeda.Models
{
    public class Tag
    {
        [Key]
        public string Name { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
