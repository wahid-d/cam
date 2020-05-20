using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cam.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string EnglishName { get; set; }

        [Required]
        public string KoreanName { get; set; }

        [Required]
        public string Level { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public DateTime Birthdate { get; set; }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(this.EnglishName) &&
            !string.IsNullOrWhiteSpace(this.KoreanName) &&
            !string.IsNullOrWhiteSpace(this.Level);
        }

    }
}