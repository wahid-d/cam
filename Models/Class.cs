using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cam.Models
{
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }

        [Required]
        public string Time { get; set; }

        [Required]
        public string CourseBook { get; set; }

        [Required]
        public string GrammarBook { get; set; }

        [Required]
        public string RoomId { get; set; }
        public Room Room { get; set; }

    }
}