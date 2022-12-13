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

        public Bartender Bartender { get; private set; } = null!;

        public TypeOfAlcohol Alcohol { get; private set; } = null!;

        public Glass Glass { get; private set; } = null!;

        public Cocktail Cocktail { get; private set; } = null!;

        public User GuestUser { get; private set; } = null!;

        private void SeedDatabase(WebAppDbContext dbContext)
        {
            this.Bartender = new Bartender()
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
            };

            dbContext.Add<Bartender>(this.Bartender);

            this.Alcohol = new TypeOfAlcohol()
            {
                Id = 1,
                Name = "Vodka"
            };

            dbContext.Add<TypeOfAlcohol>(this.Alcohol);

            this.Glass = new Glass()
            {
                Id = 1,
                Name = "Highball Glass",
                ImageUrl = "https://m.media-amazon.com/images/I/31ncXtqfK7L._SL500_.jpg",
            };

            dbContext.Add<Glass>(this.Glass);

            this.Cocktail = new Cocktail()
            {
                Id = 1,
                Name = "Georgi's Cocktail",
                Recipe = "Cocktail's Recipe",
                Preparation = "Cocktail's Preparation",
                AlcoholId = 1,
                BartenderId = 1,
                GlassId = 1,
                Image = new Image()
                {
                    ImageUrl = "https://primochef.it/wp-content/uploads/2021/06/SH_cocktail_blue_lagoon.jpg"
                }
            };

            dbContext.Add<Cocktail>(this.Cocktail);

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