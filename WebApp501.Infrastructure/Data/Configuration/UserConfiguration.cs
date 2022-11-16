using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApp501.Infrastructure.Data.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<IdentityUser> CreateUsers()
        {
            var users = new List<IdentityUser>();
            var hasher = new PasswordHasher<IdentityUser>();

            var user = new IdentityUser()
            {
                Id = "726719c4-8995-4426-9c00-1cb0831621d4",
                UserName = "dbyalkov",
                NormalizedUserName = "DBYALKOV",
                Email = "dbyalkov@abv.bg",
                NormalizedEmail = "DBYALKOV@ABV.BG"
            };

            user.PasswordHash = hasher.HashPassword(user, "bartender123");

            users.Add(user);

            user = new IdentityUser()
            {
                Id = "30342ffd-ffd8-4e66-9348-da6a2068856e",
                UserName = "d00m3r",
                NormalizedUserName = "D00M3R",
                Email = "doomar@abv.bg",
                NormalizedEmail = "DOOMAR@ABV.BG"
            };

            user.PasswordHash =
            hasher.HashPassword(user, "guest123");

            users.Add(user);

            return users;
        }
    }
}