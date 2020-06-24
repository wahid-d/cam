using System.Net.Http.Headers;
using System.IO;
using System.Runtime.InteropServices;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace cam.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [JsonPropertyName("englishName")]
        [StringLength(255, ErrorMessage = "Name is too long.")]
        public string EnglishName { get; set; }

        [JsonPropertyName("koreanName")]
        [StringLength(255, ErrorMessage = "Name is too long.")]
        public string KoreanName { get; set; }

        [JsonPropertyName("schoolName")]
        [StringLength(55, ErrorMessage = "School name is too long.")]
        public string SchoolName { get; set; }

        [StringLength(20)]
        public string Level { get; set; }

        [JsonPropertyName("schoolGrade")]
        public string Grade { get; set; }

        [JsonPropertyName("parentPhone")]
        [StringLength(20, ErrorMessage = "Phone number is too long.")]
        public string ParentPhone { get; set; }

        [JsonPropertyName("selfPhone")]
        [StringLength(20, ErrorMessage = "Phone number is too long.")]
        public string SelfPhone { get; set; }

        [JsonPropertyName("address")]
        [StringLength(255, ErrorMessage = "Address is too long.")]
        public string Address { get; set; }

        public string ClassId { get; set; }
        public Class Class { get; set; }
        
        [JsonPropertyName("className")]
        [NotMapped]
        public string ClassName { get; set; }
    }
}