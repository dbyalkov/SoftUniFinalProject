using Microsoft.EntityFrameworkCore;

using WebApp501.Core.Contracts;
using WebApp501.Core.Models.Cocktail;
using WebApp501.Infrastructure.Data.Common;
using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Core.Services
{
    public class CocktailService : ICocktailService
    {
        private readonly IRepository repo;

        public CocktailService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<bool> AlcoholExists(int alcoholId)
        {
            return await repo.AllReadonly<TypeOfAlcohol>()
                .AnyAsync(a => a.Id == alcoholId);
        }

        public async Task<CocktailsQueryModel> All(
            string? alcohol = null,
            string? searchTerm = null,
            CocktailSorting sorting = CocktailSorting.Newest,
            int currentPage = 1,
            int cocktailsPerPage = 1)
        {
            var result = new CocktailsQueryModel();
            var cocktails = repo.AllReadonly<Cocktail>()
                .Where(c => c.IsDeleted == false);

            if (string.IsNullOrEmpty(alcohol) == false)
            {
                cocktails = cocktails
                    .Where(c => c.Alcohol.Name == alcohol);
            }

            if (string.IsNullOrEmpty(searchTerm) == false)
            {
                searchTerm = $"%{searchTerm.ToLower()}%";

                cocktails = cocktails
                    .Where(c => EF.Functions.Like(c.Name.ToLower(), searchTerm) ||
                        EF.Functions.Like(c.Recipe.ToLower(), searchTerm) ||
                        EF.Functions.Like(c.Preparation.ToLower(), searchTerm));
            }

            cocktails = sorting switch
            {
                CocktailSorting.Аlphabetical => cocktails
                    .OrderBy(c => c.Name),
                _ => cocktails.OrderByDescending(c => c.Id)
            };

            result.Cocktails = await cocktails
                .Skip((currentPage - 1) * cocktailsPerPage)
                .Take(cocktailsPerPage)
                .Select(c => new CocktailServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Recipe = c.Recipe,
                    Preparation = c.Preparation,
                    ImageUrl = c.Image.ImageUrl
                })
                .ToListAsync();

            result.TotalCocktailsCount = await cocktails.CountAsync();

            return result;
        }

        public async Task<IEnumerable<string>> AllAlcoholsNames()
        {
            return await repo.AllReadonly<TypeOfAlcohol>()
                .Select(a => a.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<IEnumerable<CocktailServiceModel>> AllCocktailsByBartenderId(int id)
        {
            return await repo.AllReadonly<Cocktail>()
                .Where(c => c.IsDeleted == false)
                .Where(c => c.BartenderId == id)
                .Select(c => new CocktailServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Recipe = c.Recipe,
                    Preparation = c.Preparation,
                    ImageUrl = c.Image.ImageUrl
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<CocktailAlcoholModel>> AllTypesOfAlcohol()
        {
            return await repo.AllReadonly<TypeOfAlcohol>()
                .OrderBy(a => a.Name)
                .Select(a => new CocktailAlcoholModel()
                {
                    Id = a.Id,
                    Name = a.Name
                })
                .ToListAsync();
        }

        public async Task<CocktailServiceModel> CocktailDetailsById(int id)
        {
            return await repo.AllReadonly<Cocktail>()
                .Where(c => c.IsDeleted == false)
                .Where(c => c.Id == id)
                .Select(c => new CocktailDetailsModel()
                {
                    Id = id,
                    Name = c.Name,
                    Recipe = c.Recipe,
                    Preparation = c.Preparation,
                    Alcohol = c.Alcohol.Name,
                    Bartender = new Models.Bartender.BartenderServiceModel()
                    {
                        UserName = c.Bartender.User.UserName
                    },
                    ImageUrl = c.Image.ImageUrl
                })
                .FirstAsync();
        }

        public async Task<int> Create(CocktailModel model, int bartenderId)
        {
            var cocktail = new Cocktail()
            {
                Name = model.Name,
                Recipe = model.Recipe,
                Preparation = model.Preparation,
                BartenderId = model.BartenderId,
                AlcoholId = model.AlcoholId,
                GlassId = model.GlassId,
                Image = model.Image
            };

            await repo.AddAsync(cocktail);
            await repo.SaveChangesAsync();

            return cocktail.Id;
        }

        public async Task Delete(int cocktailId)
        {
            var cocktail = await repo.GetByIdAsync<Cocktail>(cocktailId);
            cocktail.IsDeleted = true;

            await repo.SaveChangesAsync();
        }

        public async Task Edit(int cocktailId, CocktailModel model)
        {
            var cocktail = await repo.GetByIdAsync<Cocktail>(cocktailId);

            cocktail.Name = model.Name;
            cocktail.Recipe = model.Recipe;
            cocktail.Preparation = model.Preparation;
            cocktail.AlcoholId = model.AlcoholId;
            cocktail.GlassId = model.GlassId;
            cocktail.Image.ImageUrl = model.Image.ImageUrl;

            await repo.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            return await repo.AllReadonly<Cocktail>()
                .AnyAsync(c => c.Id == id && c.IsDeleted == false);
        }

        public async Task<int> GetCocktailAlcoholId(int cocktailId)
        {
            return (await repo.GetByIdAsync<Cocktail>(cocktailId)).AlcoholId;
        }

        public async Task<IEnumerable<CocktailHomeModel>> LastTenCocktails()
        {
            return await repo.AllReadonly<Cocktail>()
                .Where(c => c.IsDeleted == false)
                .OrderByDescending(c => c.Id)
                .Select(c => new CocktailHomeModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImageUrl = c.Image.ImageUrl
                })
                .Take(10)
                .ToListAsync();
        }
    }
}