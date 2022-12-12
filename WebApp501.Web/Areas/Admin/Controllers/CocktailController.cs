using Microsoft.AspNetCore.Mvc;

using WebApp501.Core.Contracts;
using WebApp501.Web.Areas.Admin.Models;
using WebApp501.Web.Extensions;

namespace WebApp501.Web.Areas.Admin.Controllers
{
    public class CocktailController : AdminController
    {
        private readonly ICocktailService cocktailService;
        private readonly IBartenderService bartenderService;

        public CocktailController(
            ICocktailService _cocktailService,
            IBartenderService _bartenderService)
        {
            this.cocktailService = _cocktailService;
            this.bartenderService = _bartenderService;
        }

        public async Task<IActionResult> Mine()
        {
            var myCocktails = new MyCocktailsViewModel();

            var adminUserId = this.User.Id();
            var adminBartenderId = await this.bartenderService.GetBartenderIdAsync(adminUserId);

            myCocktails.AddedCocktails = await this.cocktailService.AllCocktailsByBartenderIdAsync(adminBartenderId);

            return View(myCocktails);
        }
    }
}