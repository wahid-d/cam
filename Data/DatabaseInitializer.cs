using System;
using Microsoft.AspNetCore.Identity;

namespace cam.Data
{
    public static class DatabaseInitializer
    {
        public static void SeedData(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            System.Console.WriteLine("\n============= Seeding ROLES ===============");
            SeedRoles(roleManager);
            System.Console.WriteLine("\n\n============= Seeding USERS ===============");
            SeedUsers(userManager);
            System.Console.WriteLine("============= Seeding DONE ===============\n");
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
            SeedUser(userManager, superadmin, password: "__sadmin", "superadmin");

            // add  admin 
            var admin = new AppUser() { Email = "admin@cam.eng", UserName = "Admin" };
            SeedUser(userManager, admin, password: "__admin", "admin");
            
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
                    System.Console.WriteLine($"User NOT created with email {user.Email}. Duplicate email ...");
            }
            catch(Exception e)
            {
                System.Console.WriteLine("Error Seeding users ..." + e.Message);
            }

        }
    }
}