﻿using Microsoft.AspNetCore.Identity;

using WebApp501.Infrastructure.Data.Entities;

using static WebApp501.Infrastructure.Data.AdminConstants;

namespace WebApp501.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder SeedAdmin(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var services = scopedServices.ServiceProvider;

            var userManager = services.GetRequiredService<UserManager<User>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task
                .Run(async () =>
                {
                    if (await roleManager.RoleExistsAsync(AdminRoleName))
                    {
                        return;
                    }

                    var role = new IdentityRole()
                    {
                        Name = AdminRoleName
                    };

                    await roleManager.CreateAsync(role);

                    var admin = await userManager.FindByNameAsync(AdminEmail);

                    await userManager.AddToRoleAsync(admin, role.Name);
                })
                .GetAwaiter()
                .GetResult();

            return app;
        }
    }
}