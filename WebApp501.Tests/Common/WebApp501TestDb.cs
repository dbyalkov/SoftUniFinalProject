using WebApp501.Infrastructure.Data;
using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Tests.Common
{
    public class WebApp501TestDb
    {
        public WebApp501TestDb(WebAppDbContext dbContext)
        {
            this.SeedDatabase(dbContext);
        }

        public List<Bartender> Bartenders { get; private set; } = null!;

        public List<TypeOfAlcohol> Alcohols { get; private set; } = null!;

        public List<Glass> Glasses { get; private set; } = null!;

        public List<Cocktail> Cocktails { get; private set; } = null!;

        public User GuestUser { get; private set; } = null!;

        private void SeedDatabase(WebAppDbContext dbContext)
        {
            this.Bartenders = new List<Bartender>()
            {
                new Bartender()
                {
                    Id = 1,
                    FirstName = "Georgi",
                    LastName = "Petrov",
                    Age = 20,
                    User = new User()
                    {
                        Id = "FirstBartenderUserId",
                        Email = "georgi@mail.com",
                        MiddleName = "Ivanov"
                    }
                }
            };

            dbContext.AddRange(this.Bartenders);

            this.Alcohols = new List<TypeOfAlcohol>()
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

            dbContext.AddRange(this.Alcohols);

            this.Glasses = new List<Glass>()
            {
                new Glass()
                {
                    Id = 1,
                    Name = "Old Fashioned Glass",
                    ImageUrl = "https://m.media-amazon.com/images/I/51ErdYtGOAL.jpg"
                },
                new Glass()
                {
                    Id = 2,
                    Name = "Rocks Glass",
                    ImageUrl = "https://www.cocktailkingdom.com/media/catalog/product/cache/1/image/364x/040ec09b1e35df139433887a97daa66f/g/l/gla_ckrksyarai_6101_clr_web1_1.jpg"
                },
                new Glass()
                {
                    Id = 3,
                    Name = "Cosmopolitan Glass",
                    ImageUrl = "https://johnlewis.scene7.com/is/image/JohnLewis/233596730?$rsp-pdp-port-640$"
                },
                new Glass()
                {
                    Id = 4,
                    Name = "Highball Glass",
                    ImageUrl = "https://m.media-amazon.com/images/I/31ncXtqfK7L._SL500_.jpg"
                },
                new Glass()
                {
                    Id = 5,
                    Name = "Collins Glass",
                    ImageUrl = "https://m.media-amazon.com/images/I/31vvQmBDhdL.jpg"
                },
                new Glass()
                {
                    Id = 6,
                    Name = "Zombie Glass",
                    ImageUrl = "https://cdn.shoplightspeed.com/shops/606142/files/5865756/1500x4000x3/fizz-zombie-glass-135-oz.jpg"
                },
                new Glass()
                {
                    Id = 7,
                    Name = "Weizen Glass",
                    ImageUrl = "https://hosteleria.araven.com/sites/default/files/styles/producto/public/91641_copa_weiser_cerveza.jpg?itok=9N2yaZRa"
                },
                new Glass()
                {
                    Id = 8,
                    Name = "Pilsner Glass",
                    ImageUrl = "https://www.ikea.com/my/en/images/products/oanvaend-beer-glass-clear-glass__0713254_pe729369_s5.jpg"
                },
                new Glass()
                {
                    Id = 9,
                    Name = "Sling Glass",
                    ImageUrl = "https://cdn.shopify.com/s/files/1/0520/0943/5294/products/UB15.jpg?v=1616053755"
                },
                new Glass()
                {
                    Id = 10,
                    Name = "Pint Glass",
                    ImageUrl = "https://cdnimg.webstaurantstore.com/images/products/large/41072/2310339.jpg"
                },
                new Glass()
                {
                    Id = 11,
                    Name = "Beer Mug",
                    ImageUrl = "https://www.ikea.com/us/en/images/products/mjoed-beer-mug-clear-glass__0525765_pe644916_s5.jpg?f=s"
                },
                new Glass()
                {
                    Id = 12,
                    Name = "Irish Coffee Glass",
                    ImageUrl = "https://www.sbb-bg.com/image/cache/catalog/images/Uniglass/1076_44856-550x700w.jpg"
                },
                new Glass()
                {
                    Id = 13,
                    Name = "Red Wine Glass",
                    ImageUrl = "https://m.media-amazon.com/images/I/51pEW1I+FJL._SY879_.jpg"
                },
                new Glass()
                {
                    Id = 14,
                    Name = "White Wine Glass",
                    ImageUrl = "https://www.ikea.com/gb/en/images/products/dyrgrip-white-wine-glass-clear-glass__0712421_pe728840_s5.jpg?f=s"
                },
                new Glass()
                {
                    Id = 15,
                    Name = "Ballon Wine Glass",
                    ImageUrl = "https://www.intornoalvino.com/731-large_default/red-wine-glasses-ballon-vineas.jpg"
                },
                new Glass()
                {
                    Id = 16,
                    Name = "Wine Tasting Glass",
                    ImageUrl = "https://media.nisbets.com/asset/core/prodimage/large_new/gf738_g817-1707.jpg"
                },
                new Glass()
                {
                    Id = 17,
                    Name = "Sherry Glass",
                    ImageUrl = "https://m.media-amazon.com/images/I/61DcUapHwjL.jpg"
                },
                new Glass()
                {
                    Id = 18,
                    Name = "Champagne Flute",
                    ImageUrl = "https://5.imimg.com/data5/CU/RU/SE/SELLER-25193472/ocean-champagne-flute-glass-500x500.jpg"
                },
                new Glass()
                {
                    Id = 19,
                    Name = "Champagne Coupe",
                    ImageUrl = "https://www.ikea.com/gb/en/images/products/storhet-champagne-coupe-clear-glass__0713258_pe729368_s5.jpg"
                },
                new Glass()
                {
                    Id = 20,
                    Name = "Martini Glass",
                    ImageUrl = "https://www.ikea.com/ca/en/images/products/storsint-martini-glass-clear-glass__0800268_pe767839_s5.jpg"
                },
                new Glass()
                {
                    Id = 21,
                    Name = "Margarita Glass",
                    ImageUrl = "https://www.ikea.com/om/en/images/products/festlighet-margarita-glass__0712417_pe728836_s5.jpg?f=s"
                },
                new Glass()
                {
                    Id = 22,
                    Name = "Goblet Glass",
                    ImageUrl = "https://www.webstaurantstore.com/images/products/large/88017/1877520.jpg"
                },
                new Glass()
                {
                    Id = 23,
                    Name = "Pokal Glass",
                    ImageUrl = "http://www.ajmara.pl/upd_cnt/attch/img_pro/colibri_pokal_do_piwa.jpg"
                },
                new Glass()
                {
                    Id = 24,
                    Name = "Milkshake Glass",
                    ImageUrl = "https://www.drinkstuff.com/productimg/47978_large.jpg"
                },
                new Glass()
                {
                    Id = 25,
                    Name = "Hurricane Glass",
                    ImageUrl = "https://cdnimg.webstaurantstore.com/images/products/large/232957/2396272.jpg"
                },
                new Glass()
                {
                    Id = 26,
                    Name = "Poco Grande Glass",
                    ImageUrl = "https://m.media-amazon.com/images/I/41a1riW3YxL.jpg"
                },
                new Glass()
                {
                    Id = 27,
                    Name = "Brandy Snifter",
                    ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1571017071-31p5xeITE9L.jpg?crop=1xw:0.938xh"
                },
                new Glass()
                {
                    Id = 28,
                    Name = "Wobble Cognac Glass",
                    ImageUrl = "http://1.bp.blogspot.com/-ZWq1ngNmIQM/VGZVL090-CI/AAAAAAAAbtU/L1lk0iv8_kQ/s1600/Cognac-Delamain-with-Baccarat-Le-Voyage-Decanter-Bottle-2.jpg"
                },
                new Glass()
                {
                    Id = 29,
                    Name = "Tulip Whisky Glass",
                    ImageUrl = "https://boomingglassware.com/wp-content/uploads/2019/08/BMWky-02%EF%BC%881%EF%BC%89.jpg"
                },
                new Glass()
                {
                    Id = 30,
                    Name = "Tulip Glass",
                    ImageUrl = "https://glassmania.com/media/catalog/product/cache/6b9c9ff9456b96523530d9a877110061/n/v/nvr42bsen_1.png"
                },
                new Glass()
                {
                    Id = 31,
                    Name = "Grappa Glass",
                    ImageUrl = "https://cdn.shopify.com/s/files/1/0615/8575/2295/products/Plain_-_Vintage_Grappa_Glass_-_66110_-_1052488_v1_1800x1800_56febef2-76df-4c4a-9a15-33d885d9944d_1500x.jpg?v=1640309929"
                },
                new Glass()
                {
                    Id = 32,
                    Name = "Pousse Cafe Glass",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQKc6d02gFVbrW57FF9OVXAiqUcAb8YkgPhGMWGpxaCGQ&s"
                },
                new Glass()
                {
                    Id = 33,
                    Name = "Cordial Glass",
                    ImageUrl = "https://secure.img1-cg.wfcdn.com/im/54073283/resize-h600-w600%5Ecompr-r85/1612/16121821/Cordial+Glasses.jpg"
                },
                new Glass()
                {
                    Id = 34,
                    Name = "Absinthe Glass",
                    ImageUrl = "https://assets.manufactum.de/p/020/020056/20056_01.jpg/absinthe-glass-la-rochere.jpg"
                },
                new Glass()
                {
                    Id = 35,
                    Name = "Vodka Glass",
                    ImageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/vodka-glasses-1638468889.jpg?crop=0.502xw:1.00xh;0.250xw,0&resize=640:*"
                },
                new Glass()
                {
                    Id = 36,
                    Name = "Shooter Glass",
                    ImageUrl = "https://m.media-amazon.com/images/I/51MpZbNhM-L.jpg"
                },
                new Glass()
                {
                    Id = 37,
                    Name = "Shot Glass",
                    ImageUrl = "https://media.istockphoto.com/id/178410979/photo/empty-glass.jpg?s=612x612&w=0&k=20&c=BcS4A2H_nxwc4uTWOHb2vRjLs_DgIOWk2aL4tKDzHv4="
                }
            };

            dbContext.AddRange(this.Glasses);

            this.Cocktails = new List<Cocktail>()
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
                    AlcoholId = 9,
                    BartenderId = 1,
                    GlassId = 20
                },
                new Cocktail()
                {
                    Id = 10,
                    Name = "Cocktail #10",
                    Recipe = "Recipe for Cocktail #10",
                    Preparation = "Preparation for Cocktail #10",
                    AlcoholId = 1,
                    BartenderId = 1,
                    GlassId = 2
                },
                new Cocktail()
                {
                    Id = 11,
                    Name = "Cocktail #11",
                    Recipe = "Recipe for Cocktail #11",
                    Preparation = "Preparation for Cocktail #11",
                    AlcoholId = 2,
                    BartenderId = 1,
                    GlassId = 3
                }
            };

            dbContext.AddRange(this.Cocktails);

            this.GuestUser = new User()
            {
                Id = "GuestUserId",
                Email = "guestUser@mail.com",
                MiddleName = "Guest"
            };

            dbContext.Add<User>(this.GuestUser);

            dbContext.SaveChanges();
        }
    }
}