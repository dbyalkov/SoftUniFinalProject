using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Infrastructure.Data.Configuration
{
    internal class BartenderConfiguration : IEntityTypeConfiguration<Bartender>
    {
        public void Configure(EntityTypeBuilder<Bartender> builder)
        {
            builder
                .HasData(new Bartender()
                {
                    Id = 1,
                    FirstName = "Dimitar",
                    LastName = "Byalkov",
                    Age = 28,
                    UserId = "726719c4-8995-4426-9c00-1cb0831621d4"
                });
        }
    }
}