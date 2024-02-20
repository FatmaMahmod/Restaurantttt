using System.ComponentModel.DataAnnotations;

namespace YUMMY.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "You Should enter The Name of the category")]
        public string CategoryName { get; set; }

        public virtual List<Meal>? Meals { get; set; }
    }
}
