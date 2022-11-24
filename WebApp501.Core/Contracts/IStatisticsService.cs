using WebApp501.Core.Models.Statistics;

namespace WebApp501.Core.Contracts
{
    public interface IStatisticsService
    {
        Task<StatisticsServiceModel> Total();
    }
}