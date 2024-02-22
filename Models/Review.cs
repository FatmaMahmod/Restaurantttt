using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Yummy.Data;

namespace Yummy.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "rating required")]
        public int Rating { get; set; }
        [Required(ErrorMessage = "review required")]
        public string? Comment { get; set; }
        [ForeignKey("User")]
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public virtual ApplicationUser? User { get; set; }
        

    }
}
