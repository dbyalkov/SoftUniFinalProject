using Microsoft.EntityFrameworkCore;

using WebApp501.Core.Contracts;
using WebApp501.Core.Services;
using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Tests.UnitTests
{
    [TestFixture]
    public class CocktailServiceUnitTests : UnitTestsBase
    {
        private ICocktailService cocktailService;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.cocktailService = new CocktailService(this.repo, this.mapper);
        }

        [Test]
        public async Task AllTypesOfAlcohol_ShouldReturnCorrectTypesOfAlcohol()
        {
            //Arrange

            //Act
            var result = await this.cocktailService.AllTypesOfAlcoholAsync();

            //Assert that count is correct
            var repoTypesOfAlcohol = this.repo.AllReadonly<TypeOfAlcohol>();
            Assert.That(result.Count(), Is.EqualTo(repoTypesOfAlcohol.Count()));

            //Assert that name is correct
            var repoTypeOfAlcoholName = repoTypesOfAlcohol.Select(a => a.Name);
            Assert.That(repoTypeOfAlcoholName.Contains(result.FirstOrDefault().Name));
        }

        [Test]
        public async Task AllGlasses_ShouldReturnCorrectGlasses()
        {
            //Arrange

            //Act
            var result = await this.cocktailService.AllGlassesAsync();

            //Assert that count is correct
            var repoGlasses = this.repo.AllReadonly<Glass>();
            Assert.That(result.Count(), Is.EqualTo(repoGlasses.Count()));

            //Assert that name is correct
            var repoGlassName = repoGlasses.Select(a => a.Name);
            Assert.That(repoGlassName.Contains(result.FirstOrDefault().Name));
        }

        [Test]
        public async Task LastTenCocktails_ShouldReturnCorrectCocktails()
        {
            //Arrange

            //Act
            var result = await this.cocktailService.LastTenCocktailsAsync();

            //Assert that count is correct
            var cocktailsInDb = this.repo.AllReadonly<Cocktail>()
                .OrderByDescending(c => c.Id)
                .Take(10);
            Assert.That(result.Count(), Is.EqualTo(cocktailsInDb.Count()));

            //Assert that cocktail's data is correct
            var firstCocktailIdDb = cocktailsInDb.FirstOrDefault();

            var firstResultCocktail = result.FirstOrDefault();
            Assert.That(firstResultCocktail.Id, Is.EqualTo(firstCocktailIdDb.Id));
            Assert.That(firstResultCocktail.Name, Is.EqualTo(firstCocktailIdDb.Name));
        }

        [Test]
        public async Task All_ShouldReturnCorrectCocktails()
        {
            //Arrange
            var searchTerm = "Gauguin";

            //Act
            var result = await this.cocktailService.AllAsync(null, null, searchTerm);

            //Assert the returned cocktails' count is correct
            var cocktailsInDb = this.repo.AllReadonly<Cocktail>()
                .Where(c => c.Name.Contains(searchTerm));
            Assert.That(result.TotalCocktailsCount, Is.EqualTo(cocktailsInDb.Count()));

            //Assert a returned cocktail data is correct
            var resultCocktail = result.Cocktails.FirstOrDefault();
            Assert.IsNotNull(result);

            var cocktailInDb = cocktailsInDb.FirstOrDefault();
            Assert.Multiple(() =>
            {
                Assert.That(resultCocktail.Id, Is.EqualTo(cocktailInDb.Id));
                Assert.That(resultCocktail.Name, Is.EqualTo(cocktailInDb.Name));
            });
        }
    }
}