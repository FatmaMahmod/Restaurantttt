﻿using Microsoft.AspNetCore.Identity;
using Yummy.Models;

namespace Yummy.ViewModel
{
    public class ApplicationUser : IdentityUser
    {
        public string? FristName { get; set; }
        public string? LastName { get; set; }
        public virtual List<Review>? Reviews { get; set; }



    }
}
