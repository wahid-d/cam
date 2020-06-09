using System.Runtime.InteropServices;
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
        [StringLength(55, ErrorMessage = "School name is too long.")]
        public string SchoolName { get; set; }

        [Required]
        [StringLength(20)]
        public string Level { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Phone number is too long.")]
        [Display(Prompt="01012345678")]
        public string Phone { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Address is too long.")]
        [Display(Prompt="신도림동 현대 아파트", Name="주소")]
        public string Address { get; set; }

        public string ClassId { get; set; }
        public Class Class { get; set; }
    }
}