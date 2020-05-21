using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace cam.Data
{
    public class AppUser : IdentityUser
    {
        // [Required]
        public string EnglishName { get; set; }
        
        // [Required]
        public string KoreanName { get; set; }
        public string Phone { get; set; }
        public DateTime Birthdate { get; set; }
    }
}