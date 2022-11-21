using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Infrastructure.Data.Configuration
{
    internal class CocktailConfiguration : IEntityTypeConfiguration<Cocktail>
    {
        public void Configure(EntityTypeBuilder<Cocktail> builder)
        {
            builder
                .HasData(CreateCocktails());
        }

        private List<Cocktail> CreateCocktails()
        {
            var cocktails = new List<Cocktail>()
            {
                new Cocktail()
                {
                    Id = 1,
                    Name = "Gauguin",
                    Recipe = "3 parts crushed ice\r\n" +
                             "2 parts white rum\r\n" +
                             "2 tsp passion fruit syrup\r\n" +
                             "2 tsp lemon juice\r\n" +
                             "1 tsp lime juice\r\n" +
                             "1 cocktail cherry for decoration",
                    Preparation = "Place the crushed ice, rum, syrup and lemon juice in a blender and blend on low speed for 15 seconds. Strain the resulting mixture into an old fashioned glass and garnish with the cocktail cherry.",
                    ImageId = 1,
                    AlcoholId = 1,
                    BartenderId = 1,
                    GlassId = 1
                },
                new Cocktail()
                {
                    Id = 2,
                    Name = "Toulon",
                    Recipe = "4-5 ice cubes\r\n" +
                             "1 part dry vermouth\r\n" +
                             "1 part Benedictine liqueur\r\n" +
                             "3 parts brandy\r\n" +
                             "a strip of orange peel for decoration",
                    Preparation = "Place the ice cubes in a serving glass and pour the vermouth, liqueur and brandy over them and stir vigorously. Strain the resulting mixture into a chilled cocktail glass and garnish with the orange peel.",
                    AlcoholId = 2,
                    BartenderId = 1,
                    GlassId = 20
                },
                new Cocktail()
                {
                    Id = 3,
                    Name = "Sweet Sixteen",
                    Recipe = "6-8 ice cubes\r\n" +
                             "2 parts gin\r\n" +
                             "juice of half a green lemon\r\n" +
                             "2 dashes of grenadine\r\n" +
                             "1 tsp sugar syrup\r\n" +
                             "lemon bitters\r\n" +
                             "lemon zest for garnish",
                    Preparation = "Place half the ice cubes in a shaker, pour over the gin, lime juice, grenadine and sugar syrup and shake until frosty. Put the remaining ice in a tall glass, strain the resulting mixture over the ice and top up the glass with lemon bitters. Finally, garnish with the lemon peel.",
                    AlcoholId = 3,
                    BartenderId = 1,
                    GlassId = 4
                },
                new Cocktail()
                {
                    Id = 4,
                    Name = "Sex on the Beach",
                    Recipe = "ice cubes\r\n" +
                             "1 part vodka\r\n" +
                             "1 part peach schnapps\r\n" +
                             "1 part cranberry juice\r\n" +
                             "1 part orange juice\r\n" +
                             "1 part pineapple juice (optional)\r\n" +
                             "orange slices for decoration\r\n" +
                             "slices of green lemon for decoration",
                    Preparation = "Add a few ice cubes to the shaker along with the vodka, schnapps, cranberry juice, orange juice and pineapple juice (if desired) and shake well. Put 3-4 ice cubes in a tall glass and pour the resulting mixture over them. Finally, garnish the drink with the green lemon slices and the orange slices and serve the cocktail with a straw.",
                    ImageId = 2,
                    AlcoholId = 4,
                    BartenderId = 1,
                    GlassId = 4
                },
                new Cocktail()
                {
                    Id = 5,
                    Name = "Rhett Butler",
                    Recipe = "4-5 ice cubes and extra for serving\r\n" +
                             "2 parts bourbon whiskey\r\n" +
                             "4 parts cranberry juice\r\n" +
                             "2 tbsp sugar syrup\r\n" +
                             "1 tbsp fresh lemon juice\r\n" +
                             "a slice of green lemon for garnish",
                    Preparation = "Place the ice cubes in a shaker along with the bourbon, cranberry juice, sugar syrup and lime juice and shake well. Strain the resulting mixture into an old fashioned glass filled with ice cubes, garnish with a lemon wedge and serve with a short straw.",
                    ImageId = 3,
                    AlcoholId = 5,
                    BartenderId = 1,
                    GlassId = 1
                },
                new Cocktail()
                {
                    Id = 6,
                    Name = "Cheshire Cat",
                    Recipe = "4-5 ice cubes\r\n" +
                             "1 part brandy\r\n" +
                             "1 part sweet vermouth\r\n" +
                             "champagne\r\n" +
                             "orange peels for garnish",
                    Preparation = "Put the ice cubes in a serving glass, pour over them the brandy, vermouth and orange juice and stir until a homogeneous mixture is obtained. Strain the resulting mixture into a tall champagne glass and top up with champagne. Squeeze the essential oil from one orange peel into the drink and garnish with a spiral orange peel.",
                    ImageId = 4,
                    AlcoholId = 6,
                    BartenderId = 1,
                    GlassId = 18
                },
                new Cocktail()
                {
                    Id = 7,
                    Name = "Mexicana",
                    Recipe = "8-10 ice cubes\r\n" +
                             "1 1/4 parts tequila\r\n" +
                             "3/4 part raspberry liqueur\r\n" +
                             "3/4 part fresh lemon juice\r\n" +
                             "3 1/2 parts pineapple juice\r\n" +
                             "pineapple slice for garnish\r\n" +
                             "lemon slice for garnish",
                    Preparation = "Place half of the ice cubes in a shaker along with the tequila, raspberry liqueur and fruit juices and shake vigorously for about 10 seconds. Put the remaining ice cubes in a tall glass and pour the resulting mixture over them. Finally, garnish the drink with the pineapple and lemon slice.",
                    ImageId = 5,
                    AlcoholId = 7,
                    BartenderId = 1,
                    GlassId = 4
                },
                new Cocktail()
                {
                    Id = 8,
                    Name = "Slippery Nipple",
                    Recipe = "1 part \"Sambuca\" liqueur\r\n" +
                             "1/2 part Baileys Irish Liqueur",
                    Preparation = "Pour the Sambuca liqueur into a tequila (shot) glass, then using the back of a bar spoon, slowly pour the Irish liqueur over the Sambuca so that the two liqueurs do not mix.",
                    ImageId = 6,
                    AlcoholId = 8,
                    BartenderId = 1,
                    GlassId = 37
                },
                new Cocktail()
                {
                    Id = 9,
                    Name = "Bitter Sweet",
                    Recipe = "crushed ice\r\n" +
                             "150 ml sparkling water\r\n" +
                             "2 dashes \"Angostura\" bitters\r\n" +
                             "6-8 mint leaves\r\n" +
                             "green or yellow lemon circles for decoration",
                    Preparation = "Put the crushed ice in a shaker, pour on it 2 tbsp of the sparkling water and bitters, add the mint leaves and mix until frost forms. Pour the resulting mixture into a chilled glass, fill it with sparkling water and decorate the drink with slices of green or yellow lemon.",
                    ImageId = 7,
                    AlcoholId = 9,
                    BartenderId = 1,
                    GlassId = 20
                }
            };

            return cocktails;
        }
    }
}