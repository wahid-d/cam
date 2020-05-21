using System;
using System.Collections.Generic;
using cam.Data;

namespace cam.Models
{
    public class Room
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<Class> Classes { get; set; }

        public string SupervisorId { get; set; }
        public AppUser Supervisor { get; set; }

    }
}