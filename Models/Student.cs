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
<<<<<<< HEAD
        [Display(Prompt="Sarah", Name="영어 이름")]
=======
        [Display()]
>>>>>>> 511064c5caddb650b1a40c4a92990b890ab8b093
        public string EnglishName { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Name is too long.")]
        [Display(Prompt="홍길동", Name="한국어 이름")]
        public string KoreanName { get; set; }

        [Required]
<<<<<<< HEAD
        [StringLength(55, ErrorMessage = "Grade is is too long.")]
        [Display(Prompt="초등 1", Name="학년")]
        public string Grade { get; set; }

        [Required]
        [StringLength(55, ErrorMessage = "School name is too long.")]
        [Display(Prompt="신도림 초등학교", Name="학교 이름")]
=======
        [StringLength(55, ErrorMessage = "School name is too long.")]
>>>>>>> 511064c5caddb650b1a40c4a92990b890ab8b093
        public string SchoolName { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name="레벨")]
        public string Level { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Phone number is too long.")]
<<<<<<< HEAD
        [Display(Prompt="010 1234 5678", Name="전화번호")]
=======
        [Display(Prompt="01012345678")]
>>>>>>> 511064c5caddb650b1a40c4a92990b890ab8b093
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