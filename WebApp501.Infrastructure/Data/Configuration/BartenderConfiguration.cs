using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Infrastructure.Data.Configuration
{
    /// <summary>
    /// Adds seed data to this entity type.
    /// </summary>
    internal class BartenderConfiguration : IEntityTypeConfiguration<Bartender>
    {
        public void Configure(EntityTypeBuilder<Bartender> builder)
        {
            builder
                .HasData(CreateBartenders());
        }

        private List<Bartender> CreateBartenders()
        {
            var bartenders = new List<Bartender>()
            {
                new Bartender()
                {
                    Id = 1,
                    FirstName = "Dimitar",
                    LastName = "Byalkov",
                    Age = 28,
                    UserId = "726719c4-8995-4426-9c00-1cb0831621d4"
                },
                new Bartender()
                {
                    Id = 4,
                    FirstName = "Great",
                    LastName = "Admin",
                    Age = 33,
                    UserId = "bcb4f072-ecca-43c9-ab26-c060c6f364e4"
                }
            };

            return bartenders;
        }
    }
}