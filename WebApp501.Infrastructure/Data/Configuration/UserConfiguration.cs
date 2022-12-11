using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApp501.Infrastructure.Data.Entities;

using static WebApp501.Infrastructure.Data.AdminConstants;

namespace WebApp501.Infrastructure.Data.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<User> CreateUsers()
        {
            var users = new List<User>();
            var hasher = new PasswordHasher<User>();

            var user = new User()
            {
                Id = "726719c4-8995-4426-9c00-1cb0831621d4",
                Email = "dbyalkov@abv.bg",
                NormalizedEmail = "DBYALKOV@ABV.BG",
                UserName = "dbyalkov@abv.bg",
                NormalizedUserName = "DBYALKOV@ABV.BG",
                MiddleName = "Nikolaev"
            };

            user.PasswordHash = hasher.HashPassword(user, "bartender123");
            users.Add(user);

            user = new User()
            {
                Id = "30342ffd-ffd8-4e66-9348-da6a2068856e",
                Email = "doomar@abv.bg",
                NormalizedEmail = "DOOMAR@ABV.BG",
                UserName = "doomar@abv.bg",
                NormalizedUserName = "DOOMAR@ABV.BG",
                MiddleName = "Dimitrov"
            };

            user.PasswordHash = hasher.HashPassword(user, "guest123");
            users.Add(user);

            user = new User()
            {
                Id = "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                Email = AdminEmail,
                NormalizedEmail = AdminNormalizedEmail,
                UserName = AdminEmail,
                NormalizedUserName = AdminNormalizedEmail,
                MiddleName = "Great"
            };

            user.PasswordHash = hasher.HashPassword(user, "admin123");
            users.Add(user);

            return users;
        }
    }
}