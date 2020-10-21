using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BHAMCApp.Data;
using Microsoft.AspNetCore.Identity;

namespace BHAMCApp
{
    public class DbInitializer
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                var _userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                var _roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!context.Users.Any(usr => usr.UserName == "admin@bhamc.tz"))
                {
                    var user = new ApplicationUser()
                    {
                        UserName = "admin@bhamc.tz",
                        Email = "admin@bhamc.tz",
                        EmailConfirmed = true,
                    };

                    var userResult = _userManager.CreateAsync(user, "bhamc2020").Result;
                }


                if (!_roleManager.RoleExistsAsync("admin").Result)
                {
                    var role = _roleManager.CreateAsync(new IdentityRole { Name = "admin" }).Result;
                }
                if (!_roleManager.RoleExistsAsync("Datamanager").Result)
                {
                    var role = _roleManager.CreateAsync(new IdentityRole { Name = "Datamanager" }).Result;
                }

                var adminUser = _userManager.FindByNameAsync("admin@bhamc.tz").Result;
                var adminRole = _userManager.AddToRolesAsync(adminUser, new string[] { "admin" }).Result;




            }

        }

    }
}
