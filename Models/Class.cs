using System;
using System.Collections.Generic;

namespace cam.Models
{
    public class Class
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }

        public Guid RoomId { get; set; }
        public Room Room { get; set; }

    }
}