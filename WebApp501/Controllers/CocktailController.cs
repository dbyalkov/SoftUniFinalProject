using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WebApp501.Core.Contracts;
using WebApp501.Core.Models.Cocktail;
using WebApp501.Extensions;
using WebApp501.Models;

namespace WebApp501.Controllers
{
    public class CocktailController : BaseController
    {
        private readonly ICocktailService cocktailService;
        private readonly IBartenderService bartenderService;

        public CocktailController(
            ICocktailService _cocktailService,
            IBartenderService _bartenderService)
        {
            cocktailService = _cocktailService;
            bartenderService = _bartenderService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery] AllCocktailsQueryModel query)
        {
            var result = await cocktailService.All(
                query.Alcohol,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                AllCocktailsQueryModel.CocktailsPerPage);

            query.TotalCocktailsCount = result.TotalCocktailsCount;
            query.Alcohols = await cocktailService.AllAlcoholsNames();
            query.Cocktails = result.Cocktails;

            return View(query);
        }

        public async Task<IActionResult> Mine()
        {
            IEnumerable<CocktailServiceModel> myCocktails;
            var userId = User.Id();

            int bartenderId = await bartenderService.GetBartenderId(userId);
            myCocktails = await cocktailService.AllCocktailsByBartenderId(bartenderId);

            return View(myCocktails);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id, string information)
        {
            if ((await cocktailService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var model = await cocktailService.CocktailDetailsById(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            if ((await bartenderService.ExistsById(User.Id())) == false)
            {
                return RedirectToAction(nameof(BartenderController.Become), "Bartender");
            }

            var model = new CocktailModel()
            {
                CocktailAlcohols = await cocktailService.AllTypesOfAlcohol()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CocktailModel model)
        {
            if ((await bartenderService.ExistsById(User.Id())) == false)
            {
                return RedirectToAction(nameof(BartenderController.Become), "Bartender");
            }

            if ((await cocktailService.AlcoholExists(model.AlcoholId)) == false)
            {
                ModelState.AddModelError(nameof(model.AlcoholId), "Alcohol does not exist.");
            }

            if (!ModelState.IsValid)
            {
                model.CocktailAlcohols = await cocktailService.AllTypesOfAlcohol();

                return View(model);
            }

            int bartenderId = await bartenderService.GetBartenderId(User.Id());

            int id = await cocktailService.Create(model, bartenderId);

            return RedirectToAction(nameof(Mine), new { id = id });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if ((await cocktailService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var cocktail = await cocktailService.CocktailDetailsById(id);
            int bartenderId = await bartenderService.GetBartenderId(User.Id());
            var alcoholId = await cocktailService.GetCocktailAlcoholId(id);

            var model = new CocktailModel()
            {
                Id = id,
                Name = cocktail.Name,
                Recipe = cocktail.Recipe,
                Preparation = cocktail.Preparation,
                BartenderId = bartenderId,
                AlcoholId = alcoholId,
                CocktailAlcohols = await cocktailService.AllTypesOfAlcohol()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CocktailModel model)
        {
            if (id != model.Id)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            if ((await cocktailService.Exists(model.Id)) == false)
            {
                ModelState.AddModelError("", "Cocktail does not exist.");
                model.CocktailAlcohols = await cocktailService.AllTypesOfAlcohol();

                return View(model);
            }

            if ((await cocktailService.AlcoholExists(model.AlcoholId)) == false)
            {
                ModelState.AddModelError(nameof(model.AlcoholId), "Alcohol does not exist");
                model.CocktailAlcohols = await cocktailService.AllTypesOfAlcohol();

                return View(model);
            }

            if (ModelState.IsValid == false)
            {
                model.CocktailAlcohols = await cocktailService.AllTypesOfAlcohol();

                return View(model);
            }

            await cocktailService.Edit(model.Id, model);

            return RedirectToAction(nameof(Details), new { id = model.Id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if ((await cocktailService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var cocktail = await cocktailService.CocktailDetailsById(id);
            var model = new CocktailDetailsViewModel()
            {
                Name = cocktail.Name,
                Recipe = cocktail.Recipe,
                Preparation = cocktail.Preparation,
                ImageUrl = cocktail.ImageUrl
            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id, CocktailDetailsViewModel model)
        {
            if ((await cocktailService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            await cocktailService.Delete(id);

            return RedirectToAction(nameof(All));
        }
    }
}