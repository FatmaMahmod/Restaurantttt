using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

    }
}
