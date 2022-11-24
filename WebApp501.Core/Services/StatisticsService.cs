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
            repo = _repo;
        }

        public async Task<StatisticsServiceModel> Total()
        {
            int totalCocktails = await repo.AllReadonly<Cocktail>()
                .CountAsync(c => c.IsDeleted == false);

            int totalBartenders = await repo.AllReadonly<Bartender>()
                .CountAsync(b => b.IsDeleted == false);

            return new StatisticsServiceModel()
            {
                TotalCocktails = totalCocktails,
                TotalBartenders = totalBartenders
            };
        }
    }
}