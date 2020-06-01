using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cam.Models
{
    public class Report
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        public string Period { get; set; }

        [Required]
        public int CourseScore { get; set; }

        [Required]
        public int GrammarScore { get; set; }

        [Required]
        public int EltScore { get; set; }

        public string Comment { get; set; }

        [Required]
        public string StudentId { get; set; }
    }
}