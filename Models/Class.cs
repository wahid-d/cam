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

        public string Time { get; set; }

        public string CourseBook { get; set; }

        public string GrammarBook { get; set; }

        public string RoomId { get; set; }
        public Room Room { get; set; }

    }
}