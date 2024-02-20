using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace YUMMY.Models
{
    public class Meal
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "You Should enter The Meal Name")]
        public string MealName { get; set; }
        [Required(ErrorMessage = "You Should enter The Mael Image")]
        public string MealImage { get; set; }
        public string MealRating { get; set; }
        [Required(ErrorMessage = "You Should enter The Ingredinats of the meal")]
        public string MealIngradints { get; set; }
       // [Required(ErrorMessage = "You Should enter The Category")]
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category? Category { get; set; }

        //[Required(ErrorMessage = "You Should enter The Chef")]
        //[ForeignKey("Chefs")]
        //public Chef ChefID { get; set; }
        //public virtual Chef? Chefs { get; set; }
    }
}
