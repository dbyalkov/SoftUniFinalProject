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

        public Task<CocktailsQueryModel> All(
            string? alcohol = null,
            string? searchTerm = null,
            CocktailSorting sorting = CocktailSorting.Newest,
            int currentPage = 1,
            int cocktailsPerPage = 1)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> AllAlcoholsNames()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CocktailServiceModel>> AllCocktailsByBartenderId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CocktailAlcoholModel>> AllTypesOfAlcohol()
        {
            throw new NotImplementedException();
        }

        public Task<CocktailServiceModel> CocktailDetailsById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Create(CocktailModel model, int bartenderId)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int cocktailId)
        {
            throw new NotImplementedException();
        }

        public Task Edit(int cocktailId, CocktailModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetCocktailAlcoholId(int cocktailId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CocktailHomeModel>> LastTenCocktails()
        {
            throw new NotImplementedException();
        }
    }
}