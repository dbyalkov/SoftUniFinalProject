using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using WebApp501.Core.Contracts;
using WebApp501.Models;

namespace WebApp501.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICocktailService cocktailService;

        public HomeController(ICocktailService _cocktailService)
        {
            this.cocktailService = _cocktailService;
        }

        public async Task<IActionResult> Index()
            => View(await this.cocktailService.LastTenCocktailsAsync());

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}