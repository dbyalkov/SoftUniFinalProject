using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WebApp501.Core.Constants;
using WebApp501.Core.Contracts;
using WebApp501.Web.Extensions;
using WebApp501.Web.Models.Bartender;

namespace WebApp501.Web.Controllers
{
    [Authorize]
    public class BartenderController : Controller
    {
        private readonly IBartenderService bartenderService;

        public BartenderController(IBartenderService _bartenderService)
        {
            this.bartenderService = _bartenderService;
        }

        [HttpGet]
        public async Task<IActionResult> Become()
        {
            if (await this.bartenderService.ExistsByIdAsync(User.Id()))
            {
                TempData[MessageConstant.ErrorMessage] = "You are already a bartender.";

                return RedirectToAction("Index", "Home");
            }

            var model = new BecomeBartenderFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeBartenderFormModel bartender)
        {
            var userId = this.User.Id();

            if (await this.bartenderService.ExistsByIdAsync(userId))
            {
                TempData[MessageConstant.ErrorMessage] = "You are already a bartender.";

                return RedirectToAction("Index", "Home");
            }

            if (!ModelState.IsValid)
            {
                return View(bartender);
            }

            await this.bartenderService.CreateAsync(userId, bartender.FirstName, bartender.LastName, bartender.Age);

            TempData["message"] = "You have successfully become a bartender!";

            return RedirectToAction(nameof(CocktailController.All), "Cocktail");
        }
    }
}