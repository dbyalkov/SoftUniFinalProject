﻿using WebApp501.Core.Models.Cocktail;

namespace WebApp501.Core.Contracts
{
    public interface ICocktailService
    {
        Task<IEnumerable<CocktailIndexServiceModel>> LastTenCocktailsAsync();

        Task<IEnumerable<CocktailAlcoholModel>> AllTypesOfAlcohol();

        Task<bool> AlcoholExists(int alcoholId);

        Task<int> Create(CocktailFormModel model, int bartenderId);

        Task<CocktailsQueryModel> All(
            string? alcohol = null,
            string? searchTerm = null,
            CocktailSorting sorting = CocktailSorting.Newest,
            int currentPage = 1,
            int cocktailsPerPage = 1);

        Task<IEnumerable<string>> AllAlcoholsNames();

        Task<IEnumerable<CocktailServiceModel>> AllCocktailsByBartenderId(int id);

        Task<CocktailServiceModel> CocktailDetailsById(int id);

        Task<bool> Exists(int id);

        Task Edit(int cocktailId, CocktailFormModel model);

        Task<int> GetCocktailAlcoholId(int cocktailId);

        Task Delete(int cocktailId);
    }
}