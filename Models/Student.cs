using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cam.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Name is too long.")]
        public string EnglishName { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Name is too long.")]
        public string KoreanName { get; set; }

        [Required]
        [StringLength(20)]
        public string Level { get; set; }

        [StringLength(20, ErrorMessage = "Phone number is too long.")]
        public string Phone { get; set; }

        [StringLength(255, ErrorMessage = "Address is too long.")]
        public string Address { get; set; }

        public DateTime Birthdate { get; set; }


        public string ClassId { get; set; }
        public Class Class { get; set; }
    }
}