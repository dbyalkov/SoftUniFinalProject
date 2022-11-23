using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Infrastructure.Data.Configuration
{
    internal class CocktailImageConfiguration : IEntityTypeConfiguration<CocktailImage>
    {
        public void Configure(EntityTypeBuilder<CocktailImage> builder)
        {
            builder
                .HasKey(ci => new { ci.CocktailId, ci.ImageId });

            builder
                .HasOne(ci => ci.Cocktail)
                .WithMany(ci => ci.CocktailImages)
                .HasForeignKey(ci => ci.CocktailId);

            builder
                .HasOne(ci => ci.Image)
                .WithMany(ci => ci.ImageCocktails)
                .HasForeignKey(ci => ci.ImageId);

            builder
                .HasData(CocktailsImages());
        }

        private List<CocktailImage> CocktailsImages()
        {
            var cocktailsImages = new List<CocktailImage>()
            {
                new CocktailImage()
                {
                    CocktailId = 1,
                    ImageId = 1
                },
                new CocktailImage()
                {
                    CocktailId = 4,
                    ImageId = 2
                },
                new CocktailImage()
                {
                    CocktailId = 5,
                    ImageId = 3
                },
                new CocktailImage()
                {
                    CocktailId = 6,
                    ImageId = 4
                },
                new CocktailImage()
                {
                    CocktailId = 7,
                    ImageId = 5
                },
                new CocktailImage()
                {
                    CocktailId = 8,
                    ImageId = 6
                },
                new CocktailImage()
                {
                    CocktailId = 9,
                    ImageId = 7
                },
            };

            return cocktailsImages;
        }
    }
}