using Microsoft.EntityFrameworkCore;

using WebApp501.Core.Contracts;
using WebApp501.Core.Models.Cocktail;
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
            Assert.That(firstResultCocktail?.Id, Is.EqualTo(firstCocktailIdDb?.Id));
            Assert.That(firstResultCocktail?.Name, Is.EqualTo(firstCocktailIdDb?.Name));
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
            Assert.That(repoTypeOfAlcoholName.Contains(result.FirstOrDefault()?.Name));
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
            Assert.That(repoGlassName.Contains(result.FirstOrDefault()?.Name));
        }

        [Test]
        public async Task AlcoholExists_ShouldReturnTrue()
        {
            //Arrange
            var alcoholId = this.repo.GetByIdAsync<TypeOfAlcohol>(1).Id;

            //Act
            var result = await this.cocktailService.AlcoholExistsAsync(alcoholId);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task GlassExists_ShouldReturnTrue()
        {
            //Arrange
            var glassId = this.repo.GetByIdAsync<Glass>(1).Id;

            //Act
            var result = await this.cocktailService.GlassExistsAsync(glassId);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task Create_ShouldSuccessfullyCreateCocktail()
        {
            //Arrange
            var cocktailsInDbBefore = this.repo.AllReadonly<Cocktail>().Count();

            //Arrange
            var newCocktail = new CocktailFormModel()
            {
                Name = "New Cocktail's Name",
                Recipe = "New Cocktail's Recipe",
                Preparation = "New Cocktail's Preparation",
                AlcoholId = 1,
                GlassId = 1,
                Image = "New Cocktail's Image"
            };

            //Act
            var newCocktailId = await this.cocktailService.CreateAsync(newCocktail, 1);

            //Assert that cocktails' current count has increased by one
            var cocktailsInDbAfter = this.repo.AllReadonly<Cocktail>().Count();
            Assert.That(cocktailsInDbAfter, Is.EqualTo(cocktailsInDbBefore + 1));

            //Assert the new cocktail is created with correct data
            var newCocktailInDb = await this.repo.GetByIdAsync<Cocktail>(newCocktailId);
            Assert.That(newCocktailInDb.Name, Is.EqualTo(newCocktail.Name));
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
                Assert.That(resultCocktail?.Id, Is.EqualTo(cocktailInDb?.Id));
                Assert.That(resultCocktail?.Name, Is.EqualTo(cocktailInDb?.Name));
            });
        }

        [Test]
        public async Task AllAlcoholsNames_ShouldReturnCorrectResults()
        {
            //Arrange

            //Act
            var result = await this.cocktailService.AllAlcoholsNamesAsync();

            //Assert
            var dbTypesOfAlcohol = this.repo.AllReadonly<TypeOfAlcohol>();
            Assert.That(result.Count(), Is.EqualTo(dbTypesOfAlcohol.Count()));

            //Assert
            var typesOfAlcohol = dbTypesOfAlcohol.Select(a => a.Name);
            Assert.That(typesOfAlcohol.Contains(result.FirstOrDefault()));
        }

        [Test]
        public async Task AllGlassesNames_ShouldReturnCorrectResults()
        {
            //Arrange

            //Act
            var result = await this.cocktailService.AllGlassesNamesAsync();

            //Assert
            var dbGlasses = this.repo.AllReadonly<Glass>();
            Assert.That(result.Count(), Is.EqualTo(dbGlasses.Count()));

            //Assert
            var glassNames = dbGlasses.Select(a => a.Name);
            Assert.That(glassNames.Contains(result.FirstOrDefault()));
        }

        [Test]
        public async Task AllCocktailsByBartenderId_ShouldReturnCorrectCocktails()
        {
            //Arrange
            int bartenderId = 1;

            //Act
            var result = await this.cocktailService.AllCocktailsByBartenderIdAsync(bartenderId);

            //Assert
            Assert.IsNotNull(result);

            //Assert
            var cocktailsInDbByBartenderId = this.repo.AllReadonly<Cocktail>().Where(c => c.BartenderId == bartenderId);
            Assert.That(cocktailsInDbByBartenderId.Count(), Is.EqualTo(result.Count()));
        }

        [Test]
        public async Task CocktailDetailsById_ShouldReturnCorrectCocktailData()
        {
            //Arrange
            int cocktailId = 1; 

            //Act
            var result = await this.cocktailService.CocktailDetailsByIdAsync(cocktailId);

            //Assert
            Assert.IsNotNull(result);

            //Assert
            var cocktailInDb = this.repo.AllReadonly<Cocktail>().FirstOrDefault(c => c.Id == cocktailId);
            Assert.That(cocktailInDb?.Name, Is.EqualTo(result.Name));
        }

        [Test]
        public async Task Exists_ShouldReturnTrue()
        {
            //Arrange
            int cocktailId = 1;
            int secondcocktailId = 25;

            //Act
            var result = await this.cocktailService.ExistsAsync(cocktailId);
            var secondResult = await this.cocktailService.ExistsAsync(secondcocktailId);

            //Assert
            Assert.IsTrue(result);
            Assert.IsFalse(secondResult);
        }

        [Test]
        public async Task Edit_ShouldEditCocktailCorrectly()
        {
            //Arrange
            int cocktailId = 10;

            //Act
            await this.cocktailService.EditAsync(cocktailId, new CocktailFormModel()
            {
                Name = "Cocktail #10 was edited",
                Recipe = "Recipe for Cocktail #10",
                Preparation = "Preparation for Cocktail #10",
                AlcoholId = 1,
                GlassId = 2
            });

            await this.repo.SaveChangesAsync();

            //Assert
            var editedCocktail = await this.repo.GetByIdAsync<Cocktail>(cocktailId);
            Assert.That(editedCocktail.Name, Is.EqualTo("Cocktail #10 was edited"));
        }

        [Test]
        public async Task GetCocktailAlcoholId_ShouldReturnCorrectAlcohol()
        {
            //Arrange
            int cocktailId = 1;

            //Act
            var resultAlcoholId = await this.cocktailService.GetCocktailAlcoholIdAsync(cocktailId);

            //Assert
            Assert.IsNotNull(resultAlcoholId);

            //Assert
            var alcoholId = (await this.repo.GetByIdAsync<Cocktail>(cocktailId)).AlcoholId;
            Assert.That(alcoholId, Is.EqualTo(resultAlcoholId));
        }

        [Test]
        public async Task GetCocktailGlassId_ShouldReturnCorrectGlass()
        {
            //Arrange
            int cocktailId = 1;

            //Act
            var resultGlassId = await this.cocktailService.GetCocktailGlassIdAsync(cocktailId);

            //Assert
            Assert.IsNotNull(resultGlassId);

            //Assert
            var glassId = (await this.repo.GetByIdAsync<Cocktail>(cocktailId)).GlassId;
            Assert.That(glassId, Is.EqualTo(resultGlassId));
        }

        [Test]
        public async Task HasBartenderWithId_ShouldReturnTrue()
        {
            //Arrange
            int cocktailId = 1;

            //Act
            string currUserId = (await this.repo.GetByIdAsync<Cocktail>(cocktailId)).Bartender.UserId;
            var result = await this.cocktailService.HasBartenderWithIdAsync(cocktailId, currUserId);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task Delete_ShouldSuccessfullyDeleteCocktail()
        {
            //Arrange
            int cocktailId = 11;

            var countBeforeDelete = this.repo.AllReadonly<Cocktail>()
                .Where(c => !c.IsDeleted)
                .Count();

            //Act
            await this.cocktailService.DeleteAsync(cocktailId);

            //Assert
            var countAfterDelete = this.repo.AllReadonly<Cocktail>()
                .Where(c => !c.IsDeleted)
                .Count();
            Assert.That(countAfterDelete, Is.EqualTo(countBeforeDelete - 1));
        }
    }
}