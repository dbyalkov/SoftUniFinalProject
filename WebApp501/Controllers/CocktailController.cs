using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WebApp501.Core.Contracts;
using WebApp501.Core.Models.Cocktail;
using WebApp501.Extensions;
using WebApp501.Models.Cocktail;

namespace WebApp501.Controllers
{
    [Authorize]
    public class CocktailController : Controller
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

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery] AllCocktailsQueryModel query)
        {
            var result = await this.cocktailService.AllAsync(
                query.Alcohol,
                query.Glass,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                AllCocktailsQueryModel.CocktailsPerPage);

            query.TotalCocktailsCount = result.TotalCocktailsCount;
            query.Alcohols = await this.cocktailService.AllAlcoholsNamesAsync();
            query.Glasses = await this.cocktailService.AllGlassesNamesAsync();
            query.Cocktails = result.Cocktails;

            return View(query);
        }

        public async Task<IActionResult> Mine()
        {
            IEnumerable<CocktailServiceModel>? myCocktails = null;
            var userId = this.User.Id();

            if (await this.bartenderService.ExistsByIdAsync(userId))
            {
                int bartenderId = await this.bartenderService.GetBartenderIdAsync(userId);
                myCocktails = await this.cocktailService.AllCocktailsByBartenderIdAsync(bartenderId);
            }

            return View(myCocktails);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id, string information)
        {
            if (!(await this.cocktailService.ExistsAsync(id)))
            {
                return RedirectToAction(nameof(All));
            }

            var model = await this.cocktailService.CocktailDetailsByIdAsync(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            if ((await this.bartenderService.ExistsByIdAsync(User.Id())) == false)
            {
                return RedirectToAction(nameof(BartenderController.Become), "Bartender");
            }

            var model = new CocktailFormModel()
            {
                Alcohols = await this.cocktailService.AllTypesOfAlcoholAsync(),
                Glasses = await this.cocktailService.AllGlassesAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CocktailFormModel cocktail)
        {
            if (!(await this.bartenderService.ExistsByIdAsync(this.User.Id())))
            {
                return RedirectToAction(nameof(BartenderController.Become), "Bartender");
            }

            if (!(await this.cocktailService.AlcoholExistsAsync(cocktail.AlcoholId)))
            {
                this.ModelState.AddModelError(nameof(cocktail.AlcoholId), "Alcohol does not exist.");
            }

            if (!(await this.cocktailService.GlassExistsAsync(cocktail.GlassId)))
            {
                this.ModelState.AddModelError(nameof(cocktail.GlassId), "Glass does not exist.");
            }

            if (!ModelState.IsValid)
            {
                cocktail.Alcohols = await this.cocktailService.AllTypesOfAlcoholAsync();

                return View(cocktail);
            }

            int bartenderId = await this.bartenderService.GetBartenderIdAsync(this.User.Id());

            int newCocktailId = await this.cocktailService.CreateAsync(cocktail, bartenderId);

            return RedirectToAction(nameof(Details), new { id = newCocktailId });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (!(await this.cocktailService.ExistsAsync(id)))
            {
                return RedirectToAction(nameof(All));
            }

            if (!(await this.cocktailService.HasBartenderWithIdAsync(id, this.User.Id())))
            {
                return Unauthorized();
            }

            var cocktail = await this.cocktailService.CocktailDetailsByIdAsync(id);
            var cocktailAlcoholId = await this.cocktailService.GetCocktailAlcoholIdAsync(cocktail.Id);
            var cocktailGlassId = await this.cocktailService.GetCocktailGlassIdAsync(cocktail.Id);

            var model = new CocktailFormModel()
            {
                Id = id,
                Name = cocktail.Name,
                Recipe = cocktail.Recipe,
                Preparation = cocktail.Preparation,
                AlcoholId = cocktailAlcoholId,
                GlassId = cocktailGlassId,
                Image = cocktail.ImageUrl,
                Alcohols = await this.cocktailService.AllTypesOfAlcoholAsync(),
                Glasses = await this.cocktailService.AllGlassesAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CocktailFormModel model)
        {
            if (!(await this.cocktailService.ExistsAsync(id)))
            {
                model.Alcohols = await this.cocktailService.AllTypesOfAlcoholAsync();
                model.Glasses = await this.cocktailService.AllGlassesAsync();

                return View();
            }

            if (!(await this.cocktailService.HasBartenderWithIdAsync(id, this.User.Id())))
            {
                return Unauthorized();
            }

            if (!(await this.cocktailService.AlcoholExistsAsync(model.AlcoholId)))
            {
                ModelState.AddModelError(nameof(model.AlcoholId), "Alcohol does not exist");
                model.Alcohols = await this.cocktailService.AllTypesOfAlcoholAsync();
                model.Glasses = await this.cocktailService.AllGlassesAsync();

                return View(model);
            }

            if (!(await this.cocktailService.GlassExistsAsync(model.GlassId)))
            {
                ModelState.AddModelError(nameof(model.GlassId), "Glass does not exist.");
                model.Alcohols = await this.cocktailService.AllTypesOfAlcoholAsync();
                model.Glasses = await this.cocktailService.AllGlassesAsync();

                return View(model);
            }

            if (!ModelState.IsValid)
            {
                model.Alcohols = await this.cocktailService.AllTypesOfAlcoholAsync();
                model.Glasses = await this.cocktailService.AllGlassesAsync();

                return View(model);
            }

            await this.cocktailService.EditAsync(id, model);

            return RedirectToAction(nameof(Details), new { id = id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if ((await cocktailService.ExistsAsync(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var cocktail = await cocktailService.CocktailDetailsByIdAsync(id);
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
            if ((await cocktailService.ExistsAsync(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            await cocktailService.Delete(id);

            return RedirectToAction(nameof(All));
        }
    }
}