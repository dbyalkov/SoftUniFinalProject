using Microsoft.AspNetCore.Mvc;

using WebApp501.Core.Contracts;

using static WebApp501.Infrastructure.Data.AdminConstants;

namespace WebApp501.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICocktailService cocktailService;

        public HomeController(ICocktailService _cocktailService)
        {
            this.cocktailService = _cocktailService;
        }

        public async Task<IActionResult> Index()
        {
            if (this.User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }

            var cocktails = await this.cocktailService.LastTenCocktailsAsync();

            return View(cocktails);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 400)
            {
                return View("Error400");
            }

            if (statusCode == 401)
            {
                return View("Error401");
            }

            return View();
        }
    }
}