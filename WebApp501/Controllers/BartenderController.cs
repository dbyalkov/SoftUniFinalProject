using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WebApp501.Core.Constants;
using WebApp501.Core.Contracts;
using WebApp501.Core.Models.Bartender;
using WebApp501.Extensions;

namespace WebApp501.Controllers
{
    [Authorize]
    public class BartenderController : BaseController
    {
        private readonly IBartenderService bartenderService;

        public BartenderController(IBartenderService _bartenderService)
        {
            bartenderService = _bartenderService;
        }

        [HttpGet]
        public async Task<IActionResult> Become()
        {
            if (await bartenderService.ExistsById(User.Id()))
            {
                TempData[MessageConstant.ErrorMessage] = "You are already a bartender.";

                return RedirectToAction("Index", "Home");
            }

            var model = new BecomeBartenderModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeBartenderModel model)
        {
            var userId = User.Id();

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await bartenderService.ExistsById(userId))
            {
                TempData[MessageConstant.ErrorMessage] = "You are already a bartender.";

                return RedirectToAction("Index", "Home");
            }

            if (await bartenderService.UserWithUserNameExists(model.UserName))
            {
                TempData[MessageConstant.ErrorMessage] = "User with that username already exists.";

                return RedirectToAction("Index", "Home");
            }

            await bartenderService.Create(userId, model.FirstName, model.LastName, model.Age);

            return RedirectToAction("All", "House");
        }
    }
}