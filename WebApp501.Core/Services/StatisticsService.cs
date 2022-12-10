using Microsoft.EntityFrameworkCore;

using WebApp501.Core.Contracts;
using WebApp501.Core.Models.Statistics;
using WebApp501.Infrastructure.Data.Common;
using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Core.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly IRepository repo;

        public StatisticsService(IRepository _repo)
        {
            this.repo = _repo;
        }

        public async Task<StatisticsServiceModel> Total()
        {
            int totalCocktails = await this.repo.AllReadonly<Cocktail>()
                .Where(c => c.IsDeleted == false)
                .CountAsync();

            int totalBartenders = await this.repo.AllReadonly<Bartender>()
                .Where(b => b.IsDeleted == false)
                .CountAsync();

            return new StatisticsServiceModel()
            {
                TotalCocktails = totalCocktails,
                TotalBartenders = totalBartenders
            };
        }
    }
}