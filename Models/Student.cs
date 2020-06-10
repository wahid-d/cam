using System.Net.Http.Headers;
using System.IO;
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
        [Display()]
        public string EnglishName { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Name is too long.")]
        [Display(Prompt="홍길동", Name="한국어 이름")]
        public string KoreanName { get; set; }

        [Required]
        [StringLength(55, ErrorMessage = "School name is too long.")]
        public string SchoolName { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name="레벨")]
        public string Level { get; set; }

        [Required]
        [Display(Name="학년")]
        [Range(1, 12, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Grade { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Phone number is too long.")]
        [Display(Prompt="01012345678")]
        public string Phone { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Address is too long.")]
        [Display(Prompt="신도림동 현대 아파트", Name="주소")]
        public string Address { get; set; }

        [Required]
        [Display(Name="클래스 선택")]        
        public string ClassId { get; set; }
        public Class Class { get; set; }
    }
}