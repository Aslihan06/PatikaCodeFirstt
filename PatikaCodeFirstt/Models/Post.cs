using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatikaCodeFirst.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        // Foreign Key
        [ForeignKey("User")]
        public int UserId { get; set; }

        // Navigation Property
        public User User { get; set; }
    }
}
