using AutoMapper;
using AutoMapper.QueryableExtensions;

using Microsoft.EntityFrameworkCore;

using WebApp501.Core.Contracts;
using WebApp501.Core.Models.Bartender;
using WebApp501.Core.Models.Cocktail;
using WebApp501.Infrastructure.Data.Common;
using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Core.Services
{
    /// <summary>
    /// The CocktailService class responsible for dealing with cocktail related business.
    /// </summary>
    /// <remarks>Implementation of <see cref="ICocktailService"/>.</remarks>
    public class CocktailService : ICocktailService
    {
        private readonly IRepository repo;
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="CocktailService"/> class.
        /// Constructor for the cocktail service class.
        /// </summary>
        /// <param name="_repo">The implementation of a repository to be used.</param>
        /// <param name="_mapper">Instance of an AutoMapper.</param>
        public CocktailService(
            IRepository _repo,
            IMapper _mapper)
        {
            this.repo = _repo;
            this.mapper = _mapper;
        }

        /// <inheritdoc />
        public async Task<bool> AlcoholExistsAsync(int alcoholId)
            => await this.repo.AllReadonly<TypeOfAlcohol>().AnyAsync(a => a.Id == alcoholId);

        /// <inheritdoc />
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
                .ProjectTo<CocktailServiceModel>(this.mapper.ConfigurationProvider)
                //.Select(c => new CocktailServiceModel()
                //{
                //    Id = c.Id,
                //    Name = c.Name,
                //    Recipe = c.Recipe,
                //    Preparation = c.Preparation,
                //    ImageUrl = c.Image.ImageUrl
                //})
                .ToListAsync();

            result.TotalCocktailsCount = await cocktails.CountAsync();

            return result;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<string>> AllAlcoholsNamesAsync()
            => await this.repo.AllReadonly<TypeOfAlcohol>()
                .Select(a => a.Name)
                .Distinct()
                .ToListAsync();

        /// <inheritdoc />
        public async Task<IEnumerable<CocktailServiceModel>> AllCocktailsByBartenderIdAsync(int id)
            => await this.repo.AllReadonly<Cocktail>()
                .Where(c => c.IsDeleted == false)
                .Where(c => c.BartenderId == id)
                .ProjectTo<CocktailServiceModel>(this.mapper.ConfigurationProvider)
                //.Select(c => new CocktailServiceModel()
                //{
                //    Id = c.Id,
                //    Name = c.Name,
                //    Recipe = c.Recipe,
                //    Preparation = c.Preparation,
                //    ImageUrl = c.Image.ImageUrl
                //})
                .ToListAsync();

        /// <inheritdoc />
        public async Task<IEnumerable<CocktailGlassServiceModel>> AllGlassesAsync()
            => await this.repo.AllReadonly<Glass>()
                .OrderBy(g => g.Name)
                .ProjectTo<CocktailGlassServiceModel>(this.mapper.ConfigurationProvider)
                //.Select(g => new CocktailGlassServiceModel()
                //{
                //    Id = g.Id,
                //    Name = g.Name
                //})
                .ToListAsync();

        /// <inheritdoc />
        public async Task<IEnumerable<CocktailAlcoholServiceModel>> AllTypesOfAlcoholAsync()
            => await this.repo.AllReadonly<TypeOfAlcohol>()
                .OrderBy(a => a.Name)
                .ProjectTo<CocktailAlcoholServiceModel>(this.mapper.ConfigurationProvider)
                //.Select(a => new CocktailAlcoholServiceModel()
                //{
                //    Id = a.Id,
                //    Name = a.Name
                //})
                .ToListAsync();

        /// <inheritdoc />
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
                        Email = c.Bartender.User.Email,
                        FullName = $"{c.Bartender.FirstName} {c.Bartender.User.MiddleName.Trim()} {c.Bartender.LastName}"
                    },
                })
                .FirstAsync();

        /// <inheritdoc />
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

        /// <inheritdoc />
        public async Task DeleteAsync(int cocktailId)
        {
            var cocktail = await this.repo.GetByIdAsync<Cocktail>(cocktailId);
            cocktail.IsDeleted = true;

            await this.repo.SaveChangesAsync();
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public async Task<bool> ExistsAsync(int id)
            => await this.repo.AllReadonly<Cocktail>().AnyAsync(c => c.Id == id && c.IsDeleted == false);

        /// <inheritdoc />
        public async Task<int> GetCocktailAlcoholIdAsync(int cocktailId)
            => (await this.repo.GetByIdAsync<Cocktail>(cocktailId)).AlcoholId;

        /// <inheritdoc />
        public async Task<int> GetCocktailGlassIdAsync(int cocktailId)
            => (await this.repo.GetByIdAsync<Cocktail>(cocktailId)).GlassId;

        /// <inheritdoc />
        public async Task<bool> GlassExistsAsync(int glassId)
            => await this.repo.AllReadonly<Glass>().AnyAsync(g => g.Id == glassId);

        /// <inheritdoc />
        public async Task<IEnumerable<CocktailIndexServiceModel>> LastTenCocktailsAsync()
        {
            return await this.repo.AllReadonly<Cocktail>()
                .Where(c => c.IsDeleted == false)
                .OrderByDescending(c => c.Id)
                .ProjectTo<CocktailIndexServiceModel>(this.mapper.ConfigurationProvider)
                //.Select(c => new CocktailIndexServiceModel()
                //{
                //    Id = c.Id,
                //    Name = c.Name,
                //    Recipe = c.Recipe,
                //    Preparation = c.Preparation,
                //    ImageUrl = c.Image.ImageUrl
                //})
                .Take(10)
                .ToListAsync();
        }

        /// <inheritdoc />
        public async Task<IEnumerable<string>> AllGlassesNamesAsync()
            => await this.repo.AllReadonly<Glass>()
                .Select(g => g.Name)
                .Distinct()
                .ToListAsync();

        /// <inheritdoc />
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