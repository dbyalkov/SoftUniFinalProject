using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Infrastructure.Data.Configuration
{
    internal class AlcoholConfiguration : IEntityTypeConfiguration<TypeOfAlcohol>
    {
        public void Configure(EntityTypeBuilder<TypeOfAlcohol> builder)
        {
            builder
                .HasData(CreateTypeOfAlcohols());
        }

        private List<TypeOfAlcohol> CreateTypeOfAlcohols()
        {
            var alcohols = new List<TypeOfAlcohol>()
            {
                new TypeOfAlcohol()
                {
                    Id = 1,
                    Name = "Rum"
                },
                new TypeOfAlcohol()
                {
                    Id = 2,
                    Name = "Brandy"
                },
                new TypeOfAlcohol()
                {
                    Id = 3,
                    Name = "Gin"
                },
                new TypeOfAlcohol()
                {
                    Id = 4,
                    Name = "Vodka"
                },
                new TypeOfAlcohol()
                {
                    Id = 5,
                    Name = "Whiskey"
                },
                new TypeOfAlcohol()
                {
                    Id = 6,
                    Name = "Wine and Champagne"
                },
                new TypeOfAlcohol()
                {
                    Id = 7,
                    Name = "Tequila"
                },
                new TypeOfAlcohol()
                {
                    Id = 8,
                    Name = "Other Alcoholic Beverages and Liqueurs"
                },
                new TypeOfAlcohol()
                {
                    Id = 9,
                    Name = "Non-alcoholic Cocktails"
                }
             };

            return alcohols;
        }
    }
}