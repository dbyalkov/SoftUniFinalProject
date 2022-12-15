using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Infrastructure.Data.Configuration
{
    /// <summary>
    /// Adds seed data to this entity type.
    /// </summary>
    internal class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder
                .HasData(CreateImages());
        }

        private List<Image> CreateImages()
        {
            var images = new List<Image>()
                {
                new Image()
                {
                    Id = 1,
                    ImageUrl = "https://cdn.diffords.com/contrib/stock-images/2018/05/5af304cee08a4.jpg",
                    CocktailId = 1
                },
                new Image()
                {
                    Id = 2,
                    ImageUrl = "https://copykat.com/wp-content/uploads/2022/05/Sex-on-the-Beach-Drink-Pin-9.jpg",
                    CocktailId = 4
                },
                new Image()
                {
                    Id = 3,
                    ImageUrl = "https://cdn.diffords.com/contrib/stock-images/2017/1/16/20177572d2119c567079c338b14db4eb375e.jpg",
                    CocktailId = 5
                },
                new Image()
                {
                    Id = 4,
                    ImageUrl = "https://media-cdn.tripadvisor.com/media/photo-m/1280/13/88/99/f9/cheshire-cat-cocktail.jpg",
                    CocktailId = 6
                },
                new Image()
                {
                    Id = 5,
                    ImageUrl = "https://vinepair.com/wp-content/uploads/2017/09/Mexicano_Card.jpg",
                    CocktailId = 7
                },
                new Image()
                {
                    Id = 6,
                    ImageUrl = "https://cocktailsandshots.com/wp-content/uploads/2018/06/Slippery-nipple-shot-recipe-with-ingredients-sambuca-baileys.jpg",
                    CocktailId = 8
                },
                new Image()
                {
                    Id = 7,
                    ImageUrl = "https://cdn.diffords.com/contrib/stock-images/2016/10/53/201600e4ec5eb6ed8167e09d75ed35abe569.jpg",
                    CocktailId = 9
                }
                };

            return images;
        }
    }
}