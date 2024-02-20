﻿using System.ComponentModel.DataAnnotations;

namespace YUMMY.Models
{
    public class Chef
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "You Should enter The Chef Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You Should enter The Job Title of the Chef")]
        public string JobTitle { get; set; }
        [Required(ErrorMessage = "You Should enter a brief about the Chef")]
        public string Brief { get; set; }
        public string Image { get; set; }
    }
}
