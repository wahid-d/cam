using System.Linq;
using System;
using cam.Models;
using Microsoft.AspNetCore.Identity;

namespace cam.Data
{
    public static class DatabaseInitializer
    {
        public static void SeedData(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            System.Console.WriteLine("\n============= Seeding ROLES ===============");
            SeedRoles(roleManager);
            System.Console.WriteLine("\n\n============= Seeding USERS ===============");
            SeedUsers(userManager);
            System.Console.WriteLine("============= Seeding DONE ===============\n\n");


            SeedRooms(userManager, context);
            SeedClass(context);
        }

        private static void SeedClass(ApplicationDbContext context)
        {
            var library = context.Rooms.Where(r => r.Name == "Library").FirstOrDefault();
            if((context.Classes.Where(r => r.Name == "UNSORTED").FirstOrDefault()) == null)
            {
                var cl = new Class() { Room = library, RoomId = library.Id, Name = "UNSORTED",  GrammarBook = "", CourseBook = "", Time = "" };
                var result = context.Classes.AddAsync(cl).Result;
                var saveResult = context.SaveChangesAsync().Result;
            }
            else
            {
                System.Console.WriteLine($"UNSORTED class already exists ...");
            }
        }

        private static void SeedRooms(UserManager<AppUser> userManager, ApplicationDbContext context)
        {
            var rooms = new []{ "London", "NewYork", "Athen", "Paris", "Rome", "Library" };
            foreach(var room in rooms)
            {
                if((context.Rooms.Where(r => r.Name == room).FirstOrDefault()) == null)
                {
                    var user = userManager.FindByNameAsync(room).Result;
                    if(user != null)
                    {
                        var createResult = context.Rooms.AddAsync(new Room() { Name = room, SupervisorUserName = user.UserName }).Result;
                    }
                    else
                        System.Console.WriteLine($"Could NOT create room {room} ...");   
                }
                else
                {
                    System.Console.WriteLine($"Room {room} already exists ...");
                }
            }

            var result = context.SaveChangesAsync().Result;
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            var roles = new []{ "superadmin", "admin", "teacher", "student"};
            foreach(var role in roles)
            {
                try
                {
                    if(!roleManager.RoleExistsAsync(role).Result)
                    {
                        IdentityRole newRole = new IdentityRole(){ Name = role };
                        var result = roleManager.CreateAsync(newRole).Result;

                        if(result.Succeeded)
                            System.Console.WriteLine($"Role {role} successfully seeded to DB...");
                        else
                            System.Console.WriteLine($"Role {role} could NOT be seeded to DB...");

                    }
                    else
                        System.Console.WriteLine($"Role {role} exists already, so not seeded to DB...");

                }
                catch(Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
            }
        }

        private static void SeedUsers(UserManager<AppUser> userManager)
        {
            // add super admin 
            var superadmin = new AppUser() { Email = "sadmin@cam.eng", UserName = "SuperAdmin" };
            SeedUser(userManager, superadmin, password: "sadmin", "superadmin");

            // add  admin 
            var admin = new AppUser() { Email = "admin@cam.eng", UserName = "Admin" };
            SeedUser(userManager, admin, password: "admin", "admin");
            
            // add teachers
            var teachers = new []
            {
                new AppUser(){ Email = "london@cam.eng", UserName = "London" },
                new AppUser(){ Email = "newyork@cam.eng", UserName = "NewYork" },
                new AppUser(){ Email = "athen@cam.eng", UserName = "Athen" },
                new AppUser(){ Email = "paris@cam.eng", UserName = "Paris" },
                new AppUser(){ Email = "rome@cam.eng", UserName = "Rome" },
                new AppUser(){ Email = "library@cam.eng", UserName = "Library" }
            };
            foreach(var teacher in teachers)
            {
                var password = "_" + teacher.Email.Substring(0, teacher.Email.IndexOf("@"));
                SeedUser(userManager, teacher, password, "teacher");
            }
        }

        private static void SeedUser(UserManager<AppUser> userManager, AppUser user, string password, string role)
        {
            try
            {
                if(userManager.FindByEmailAsync(user.Email).Result == null)
                {
                    var result = userManager.CreateAsync(user, password).Result;
                    if(result.Succeeded)
                    {
                        System.Console.WriteLine($"User created with email {user.Email} successfully...");

                        userManager.AddToRoleAsync(user, role).Wait();

                    }
                    else
                        System.Console.WriteLine($"User NOT created with email {user.Email} ...");
                }
                else
                {
                    System.Console.WriteLine($"User NOT created with email {user.Email}. Duplicate email ...");
                }
            }
            catch(Exception e)
            {
                System.Console.WriteLine("Error Seeding users ..." + e.Message);
            }

        }
    }
}