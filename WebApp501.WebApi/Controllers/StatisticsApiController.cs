using Microsoft.AspNetCore.Mvc;

using WebApp501.Core.Contracts;
using WebApp501.Core.Models.Statistics;

namespace WebApp501.WebApi.Controllers
{
    [ApiController]
    [Route("api/statistics")]
    public class StatisticsApiController : ControllerBase
    {
        private readonly IStatisticsService service;

        public StatisticsApiController(IStatisticsService _service)
        {
            this.service = _service;
        }

        /// <summary>
        /// Gets statistics about number of cocktails and bartenders
        /// </summary>
        /// <returns>Total cocktails and total bartenders</returns>
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(StatisticsServiceModel))]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetStatistics()
        {
            var model = await this.service.Total();

            return Ok(model);
        }
    }
}