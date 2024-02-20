﻿using System.ComponentModel.DataAnnotations;

namespace YUMMY.Models
{
    public class Event
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "You Should enter The Name of the Event")]
        public string EventName { get; set; }
        [Required(ErrorMessage = "You Should enter The Description of the Event")]
        public string EventDescription { get; set; }
        [Required(ErrorMessage = "You Should enter The Price of the Event")]
        public int EventPricce { get; set; }
        public string EventImage { get; set; }
    }
}
