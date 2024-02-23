using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace YUMMY.Models
{
    public class Meal
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "You Should enter The Meal Name")]
        public string MealName { get; set; }
        [Required(ErrorMessage = "You Should enter The Mael Image")]
        public string? MealImage { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
        [Required(ErrorMessage = "You Should enter The Price of the meal")]
        public int MealPrice { get; set; }
        public string? MealRating { get; set; }
        [Required(ErrorMessage = "You Should enter The Ingredinats of the meal")]
        public string MealIngradints { get; set; }
       // [Required(ErrorMessage = "You Should enter The Category")]
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category? Category { get; set; }

        
    }
}
