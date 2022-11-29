using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using WebApp501.Core.Contracts;
using WebApp501.Models;

namespace WebApp501.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ICocktailService cocktailService;

        public HomeController(ICocktailService _cocktailService)
        {
            cocktailService = _cocktailService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await cocktailService.LastTenCocktails());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}