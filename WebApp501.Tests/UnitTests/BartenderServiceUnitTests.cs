using WebApp501.Core.Contracts;
using WebApp501.Core.Services;
using WebApp501.Infrastructure.Data.Entities;
using WebApp501.Tests.Common;

namespace WebApp501.Tests.UnitTests
{
    public class BartenderServiceUnitTests : UnitTestsBase
    {
        private IBartenderService bartenderService;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.bartenderService = new BartenderService(this.repo);
        }

        [Test]
        public async Task ExistsById_ShouldReturnTrue()
        {
            //Arrange
            int bartenderId = 1;
            string userId = (await this.repo.GetByIdAsync<Bartender>(bartenderId)).UserId;

            //Act
            var result = await this.bartenderService.ExistsByIdAsync(userId);

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task UsersCocktails_ShouldReturnCorrectCount()
        {
            //Arrange
            int bartenderId = 1;
            string userId = (await this.repo.GetByIdAsync<Bartender>(bartenderId)).UserId;

            //Act
            var resultBartenderCocktails = await this.bartenderService.UsersCocktailsAsync(userId);

            //Assert
            var bartenderCocktails = this.repo.AllReadonly<Cocktail>()
                .Where(c => c.Bartender.UserId == userId)
                .Count();
            Assert.That(resultBartenderCocktails, Is.EqualTo(bartenderCocktails));
        }

        [Test]
        public async Task Create_ShouldSuccessfullyCreateBartender()
        {
            //Arrange
            var bartendersInDbBefore = this.repo.AllReadonly<Bartender>().Count();

            var newBartender = new Bartender
            {
                Id = 2,
                FirstName = "FirstName",
                LastName = "LastName",
                Age = 22,
                UserId = "SecondBartenderUserId",
                User = new User()
                {
                    Email = "firstName@mail.com",
                    MiddleName = "MiddleName"
                }
            };

            //Act
            await this.bartenderService.CreateAsync(newBartender.UserId, newBartender.FirstName, newBartender.LastName, newBartender.Age);

            //Assert that bartenders' current count has increased by one
            var bartendersInDbAfter = this.repo.AllReadonly<Bartender>().Count();
            Assert.That(bartendersInDbAfter, Is.EqualTo(bartendersInDbBefore + 1));

            //Assert the new bartender is created with correct data
            var newBartenderInDb = await this.repo.GetByIdAsync<Bartender>(newBartender.Id);
            Assert.That(newBartenderInDb.FirstName, Is.EqualTo(newBartender.FirstName));
        }

        [Test]
        public async Task GetBartenderId_ShouldSuccessfullyReturnBartenderId()
        {
            //Arrange
            int bartenderId = 1;
            string userId = (await this.repo.GetByIdAsync<Bartender>(bartenderId)).UserId;

            //Act
            var resultBartenderId = await this.bartenderService.GetBartenderIdAsync(userId);

            //Assert
            Assert.IsNotNull(resultBartenderId);
            Assert.That(resultBartenderId, Is.EqualTo(bartenderId));
        }
    }
}