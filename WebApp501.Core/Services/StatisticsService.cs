using Microsoft.EntityFrameworkCore;

using WebApp501.Core.Contracts;
using WebApp501.Core.Models.Statistics;
using WebApp501.Infrastructure.Data.Common;
using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Core.Services
{
    /// <summary>
    /// The StatisticsService class responsible for dealing with statistics related business.
    /// </summary>
    /// <remarks>Implementation of <see cref="IStatisticsService"/>.</remarks>
    public class StatisticsService : IStatisticsService
    {
        private readonly IRepository repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsService"/> class.
        /// Constructor for the statistics service class.
        /// </summary>
        /// <param name="_repo">The implementation of a repository to be used.</param>
        public StatisticsService(IRepository _repo)
        {
            this.repo = _repo;
        }

        /// <inheritdoc />
        public async Task<StatisticsServiceModel> Total()
        {
            int totalCocktails = await this.repo.AllReadonly<Cocktail>()
                .Where(c => c.IsDeleted == false)
                .CountAsync();

            int totalBartenders = await this.repo.AllReadonly<Bartender>()
                .CountAsync();

            return new StatisticsServiceModel()
            {
                TotalCocktails = totalCocktails,
                TotalBartenders = totalBartenders
            };
        }
    }
}