using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Yummy.Data;
using YUMMY.Models;

namespace Yummy.Models
{//apple -> mealid->4 usid->20 
    // fish ->3 ->20



    //cart1 ->1 mealid-> 2  uid-> 1
    //cart2 ->2 mealid-> 3  uid->1

    //order table 1-totalsum 2- datenow 3-dateafter2day 4-locationofuser



    //cart repressent one product have from 1 to m count 
    // one meal have one cart have from 1 to m count 
    public class cart
    {
        [Key]
        public int Id { get; set; }

        // Add ForeignKey attribute for MealId
        [ForeignKey("Meal")]
        public int? MealId { get; set; }

        public Meal? Meal { get; set; }

        // Add ForeignKey attribute for ApplicationUserId
        [ForeignKey("ApplicationUser")]
        public string? ApplicationUserId { get; set; }

        public ApplicationUser? ApplicationUser { get; set; }

        [Required(ErrorMessage = "Count is required")]
       [Range(1, int.MaxValue, ErrorMessage = "Count must be greater than or equal to 1")]
        public int Count { get; set; }
    }

}
