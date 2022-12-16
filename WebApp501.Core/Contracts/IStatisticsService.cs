using WebApp501.Core.Models.Statistics;

namespace WebApp501.Core.Contracts
{
    /// <summary>
    /// The interface for the StatisticsService.
    /// </summary>
    public interface IStatisticsService
    {
        /// <summary>
        /// Used for retrieving the total count of all cocktails and all bartenders.
        /// </summary>
        /// <returns>A statistics service model.</returns>
        Task<StatisticsServiceModel> Total();
    }
}