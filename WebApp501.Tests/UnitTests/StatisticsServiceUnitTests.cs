using WebApp501.Core.Contracts;
using WebApp501.Core.Services;
using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Tests.UnitTests
{
    [TestFixture]
    public class StatisticsServiceUnitTests : UnitTestsBase
    {
        private IStatisticsService statisticsService;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.statisticsService = new StatisticsService(this.repo);
        }

        [Test]
        public async Task Total_ShouldReturnCorrectCounts()
        {
            //Arrange

            //Act
            var statistics = await this.statisticsService.Total();

            //Assert
            Assert.IsNotNull(statistics);

            //Assert
            var totalCocktails = this.repo.AllReadonly<Cocktail>()
                .Where(c => !c.IsDeleted)
                .Count();

            var totalBartenders = this.repo.AllReadonly<Bartender>()
                .Count();

            Assert.Multiple(() =>
            {
                Assert.That(totalCocktails, Is.EqualTo(statistics.TotalCocktails));
                Assert.That(totalBartenders, Is.EqualTo(statistics.TotalBartenders));
            });
        }
    }
}