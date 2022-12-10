using Microsoft.EntityFrameworkCore;

using WebApp501.Core.Contracts;
using WebApp501.Core.Models.Bartender;
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
            this.repo = _repo;
        }

        public async Task<bool> AlcoholExistsAsync(int alcoholId)
            => await this.repo.AllReadonly<TypeOfAlcohol>().AnyAsync(a => a.Id == alcoholId);

        public async Task<CocktailsQueryServiceModel> AllAsync(
            string? alcohol = null,
            string? glass = null,
            string? searchTerm = null,
            CocktailSorting sorting = CocktailSorting.Newest,
            int currentPage = 1,
            int cocktailsPerPage = 1)
        {
            var result = new CocktailsQueryServiceModel();
            var cocktails = this.repo.AllReadonly<Cocktail>()
                .Where(c => c.IsDeleted == false);

            if (!string.IsNullOrEmpty(alcohol))
            {
                cocktails = cocktails
                    .Where(c => c.Alcohol.Name == alcohol);
            }

            if (!string.IsNullOrEmpty(glass))
            {
                cocktails = cocktails
                    .Where(c => c.Glass.Name == glass);
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

        public async Task<IEnumerable<string>> AllAlcoholsNamesAsync()
            => await this.repo.AllReadonly<TypeOfAlcohol>()
                .Select(a => a.Name)
                .Distinct()
                .ToListAsync();

        public async Task<IEnumerable<CocktailServiceModel>> AllCocktailsByBartenderIdAsync(int id)
            => await this.repo.AllReadonly<Cocktail>()
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

        public async Task<IEnumerable<CocktailGlassServiceModel>> AllGlassesAsync()
            => await this.repo.AllReadonly<Glass>()
                .OrderBy(g => g.Name)
                .Select(g => new CocktailGlassServiceModel()
                {
                    Id = g.Id,
                    Name = g.Name
                })
                .ToListAsync();

        public async Task<IEnumerable<CocktailAlcoholServiceModel>> AllTypesOfAlcoholAsync()
            => await this.repo.AllReadonly<TypeOfAlcohol>()
                .OrderBy(a => a.Name)
                .Select(a => new CocktailAlcoholServiceModel()
                {
                    Id = a.Id,
                    Name = a.Name
                })
                .ToListAsync();

        public async Task<CocktailDetailsServiceModel> CocktailDetailsByIdAsync(int id)
            => await this.repo.AllReadonly<Cocktail>()
                .Where(c => c.IsDeleted == false)
                .Where(c => c.Id == id)
                .Select(c => new CocktailDetailsServiceModel()
                {
                    Id = id,
                    Name = c.Name,
                    Recipe = c.Recipe,
                    Preparation = c.Preparation,
                    ImageUrl = c.Image.ImageUrl,
                    Alcohol = c.Alcohol.Name,
                    Glass = c.Glass.Name,
                    Bartender = new BartenderServiceModel()
                    {
                        UserName = c.Bartender.User.UserName,
                        Email = c.Bartender.User.Email
                    },
                })
                .FirstAsync();

        public async Task<int> CreateAsync(CocktailFormModel model, int bartenderId)
        {
            var cocktail = new Cocktail()
            {
                Name = model.Name,
                Recipe = model.Recipe,
                Preparation = model.Preparation,
                BartenderId = bartenderId,
                AlcoholId = model.AlcoholId,
                GlassId = model.GlassId,
                Image = new Image()
                {
                    ImageUrl = model.Image
                }
            };

            await this.repo.AddAsync(cocktail);
            await this.repo.SaveChangesAsync();

            return cocktail.Id;
        }

        public async Task DeleteAsync(int cocktailId)
        {
            var cocktail = await this.repo.GetByIdAsync<Cocktail>(cocktailId);
            cocktail.IsDeleted = true;

            await this.repo.SaveChangesAsync();
        }

        public async Task EditAsync(int cocktailId, CocktailFormModel model)
        {
            var cocktail = await this.repo.GetByIdAsync<Cocktail>(cocktailId);

            cocktail.Name = model.Name;
            cocktail.Recipe = model.Recipe;
            cocktail.Preparation = model.Preparation;
            cocktail.AlcoholId = model.AlcoholId;
            cocktail.GlassId = model.GlassId;

            await this.repo.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(int id)
            => await this.repo.AllReadonly<Cocktail>().AnyAsync(c => c.Id == id && c.IsDeleted == false);

        public async Task<int> GetCocktailAlcoholIdAsync(int cocktailId)
            => (await this.repo.GetByIdAsync<Cocktail>(cocktailId)).AlcoholId;

        public async Task<int> GetCocktailGlassIdAsync(int cocktailId)
            => (await this.repo.GetByIdAsync<Cocktail>(cocktailId)).GlassId;

        public async Task<bool> GlassExistsAsync(int glassId)
            => await this.repo.AllReadonly<Glass>().AnyAsync(g => g.Id == glassId);

        public async Task<IEnumerable<CocktailIndexServiceModel>> LastTenCocktailsAsync()
        {
            return await this.repo.AllReadonly<Cocktail>()
                .Where(c => c.IsDeleted == false)
                .OrderByDescending(c => c.Id)
                .Select(c => new CocktailIndexServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImageUrl = c.Image.ImageUrl,
                    Recipe = c.Recipe,
                    Preparation = c.Preparation
                })
                .Take(10)
                .ToListAsync();
        }

        public async Task<IEnumerable<string>> AllGlassesNamesAsync()
            => await this.repo.AllReadonly<Glass>()
                .Select(g => g.Name)
                .Distinct()
                .ToListAsync();

        public async Task<bool> HasBartenderWithIdAsync(int cocktailId, string currUserId)
        {
            var cocktail = await this.repo.GetByIdAsync<Cocktail>(cocktailId);
            var bartender = await this.repo.AllReadonly<Bartender>()
                .FirstOrDefaultAsync(b => b.Id == cocktail.BartenderId);

            if (bartender == null || bartender.UserId != currUserId)
            {
                return false;
            }

            return true;
        }
    }
}