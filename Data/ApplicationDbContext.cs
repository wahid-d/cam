using System;
using System.Collections.Generic;
using System.Text;
using cam.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace cam.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity("cam.Models.Class", b =>
                {
                    b.HasOne("cam.Models.Room", "Room")
                        .WithMany("Classes")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("cam.Models.Student", b =>
                {
                    b.HasOne("cam.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            
            modelBuilder.Entity<Class>().HasData(new Class() { Name = "UNSORTED", Id = "1" });
            modelBuilder.Entity<Room>().HasData(new Room() { Name = "Library", Id = "1" });

            base.OnModelCreating(modelBuilder);
        }

    }
}
