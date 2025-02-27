﻿//using Microsoft.AspNet.Identity.EntityFramework;

//namespace HospitalManagement.BL.Extensions
//{
//    public class SeedExtension
//    {
//        public static class SeedExtension
//        {
//            public static void UseUserSeed(this IApplicationBuilder app)
//            {
//                using (var scope = app.ApplicationServices.CreateScope())
//                {

//                    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
//                    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
//                    CreateRoles(roleManager);
//                    CreateUsers(userManager);

//                }
//            }
//            private static async void CreateUsers(UserManager<AppUser> _userManager)
//            {
//                if (!await _userManager.Users.AnyAsync(z => z.NormalizedUserName == "ADMIN"))
//                {
//                    AppUser user = new AppUser();
//                    user.UserName = "admin";
//                    user.Email = "admin@gmail.com";
//                    user.Fullname = "admin";
//                    user.EmailConfirmed = true;
//                    string role = nameof(Roles.Admin);
//                    await _userManager.CreateAsync(user, "123");
//                    await _userManager.AddToRoleAsync(user, role);
//                }
//            }
//            private static async void CreateRoles(RoleManager<IdentityRole> _roleManager)
//            {
//                if (!await _roleManager.Roles.AnyAsync())
//                {
//                    foreach (Roles role in Enum.GetValues(typeof(Roles)))
//                    {
//                        await _roleManager.CreateAsync(new IdentityRole(role.GetRole()));
//                    }
//                }
//            }
//        }
//    }
//}
