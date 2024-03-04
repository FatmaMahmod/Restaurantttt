using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using Yummy.ViewModel;

namespace Yummy.Models
{
	public class Booking
	{
        [Key]
		public int ID { get; set; }
        [Required(ErrorMessage = "this field required")]
        public string Name { get; set; }
		[Required(ErrorMessage ="this field required")]
		[Range(1,15,ErrorMessage = "from 1 to 15 member")]
        [DisplayName("How many guests?")]
        public int peopleNumber { get; set; }
		[Required(ErrorMessage = "this field required")]
		[RegularExpression("^01[0125][0-9]{8}$", ErrorMessage = "this number is invalid")]
		public string Phone { get; set; }

        [Required(ErrorMessage ="this field required")]
		//[RegularExpression("", ErrorMessage = "this date is reserved")]
		public DateTime Date { get; set; }

		public string? Message { get; set; }

		[ForeignKey("User")]
		public string? userID { get; set; }
		public ApplicationUser? User { get; set; }
	}
}
