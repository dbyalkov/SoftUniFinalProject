using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WebApp501.Core.Contracts;
using WebApp501.Core.Extensions;
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

            var modelCocktail = await this.cocktailService.CocktailDetailsByIdAsync(id);

            if (information != modelCocktail.GetInformation())
            {
                return RedirectToAction(nameof(All));
            }

            return View(modelCocktail);
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

            return RedirectToAction(nameof(Details), new { id = newCocktailId, information = cocktail.GetInformation() });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (!(await this.cocktailService.ExistsAsync(id)))
            {
                return RedirectToAction(nameof(All));
            }

            if (!(await this.cocktailService.HasBartenderWithIdAsync(id, this.User.Id())) && !this.User.IsAdmin())
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
        public async Task<IActionResult> Edit(int id, CocktailFormModel cocktail)
        {
            if (!(await this.cocktailService.ExistsAsync(id)))
            {
                cocktail.Alcohols = await this.cocktailService.AllTypesOfAlcoholAsync();
                cocktail.Glasses = await this.cocktailService.AllGlassesAsync();

                return View();
            }

            if (!(await this.cocktailService.HasBartenderWithIdAsync(id, this.User.Id())) && !this.User.IsAdmin())
            {
                return Unauthorized();
            }

            if (!(await this.cocktailService.AlcoholExistsAsync(cocktail.AlcoholId)))
            {
                ModelState.AddModelError(nameof(cocktail.AlcoholId), "Alcohol does not exist");
                cocktail.Alcohols = await this.cocktailService.AllTypesOfAlcoholAsync();
                cocktail.Glasses = await this.cocktailService.AllGlassesAsync();

                return View(cocktail);
            }

            if (!(await this.cocktailService.GlassExistsAsync(cocktail.GlassId)))
            {
                ModelState.AddModelError(nameof(cocktail.GlassId), "Glass does not exist.");
                cocktail.Alcohols = await this.cocktailService.AllTypesOfAlcoholAsync();
                cocktail.Glasses = await this.cocktailService.AllGlassesAsync();

                return View(cocktail);
            }

            if (!ModelState.IsValid)
            {
                cocktail.Alcohols = await this.cocktailService.AllTypesOfAlcoholAsync();
                cocktail.Glasses = await this.cocktailService.AllGlassesAsync();

                return View(cocktail);
            }

            await this.cocktailService.EditAsync(id, cocktail);

            return RedirectToAction(nameof(Details), new { id = id, information = cocktail.GetInformation() });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (!(await this.cocktailService.ExistsAsync(id)))
            {
                return RedirectToAction(nameof(All));
            }

            if (!(await this.cocktailService.HasBartenderWithIdAsync(id, this.User.Id())) && !this.User.IsAdmin())
            {
                return Unauthorized();
            }

            var cocktail = await this.cocktailService.CocktailDetailsByIdAsync(id);

            var model = new CocktailDetailsViewModel()
            {
                Name = cocktail.Name,
                ImageUrl = cocktail.ImageUrl
            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Delete(CocktailDetailsViewModel model)
        {
            if (!(await this.cocktailService.ExistsAsync(model.Id)))
            {
                return RedirectToAction(nameof(All));
            }

            if (!(await this.cocktailService.HasBartenderWithIdAsync(model.Id, this.User.Id())) && !this.User.IsAdmin())
            {
                return Unauthorized();
            }

            await this.cocktailService.DeleteAsync(model.Id);

            return RedirectToAction(nameof(All));
        }
    }
}