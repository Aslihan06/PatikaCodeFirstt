using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PatikaCodeFirst.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Navigation Property
        public ICollection<Post> Posts { get; set; }
    }
}

