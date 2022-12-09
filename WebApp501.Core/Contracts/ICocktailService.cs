﻿using WebApp501.Core.Models.Cocktail;

namespace WebApp501.Core.Contracts
{
    public interface ICocktailService
    {
        Task<IEnumerable<CocktailIndexServiceModel>> LastTenCocktailsAsync();

        Task<IEnumerable<CocktailAlcoholServiceModel>> AllTypesOfAlcoholAsync();

        Task<IEnumerable<CocktailGlassServiceModel>> AllGlassesAsync();

        Task<bool> AlcoholExistsAsync(int alcoholId);

        Task<bool> GlassExistsAsync(int glassId);

        Task<int> CreateAsync(CocktailFormModel model, int bartenderId);

        Task<CocktailsQueryServiceModel> AllAsync(
            string? alcohol = null,
            string? glass = null,
            string? searchTerm = null,
            CocktailSorting sorting = CocktailSorting.Newest,
            int currentPage = 1,
            int cocktailsPerPage = 1);

        Task<IEnumerable<string>> AllAlcoholsNamesAsync();

        Task<IEnumerable<string>> AllGlassesNamesAsync();

        Task<IEnumerable<CocktailServiceModel>> AllCocktailsByBartenderIdAsync(int id);

        Task<CocktailDetailsServiceModel> CocktailDetailsByIdAsync(int id);

        Task<bool> ExistsAsync(int id);

        Task EditAsync(int cocktailId, CocktailFormModel model);

        Task<int> GetCocktailAlcoholIdAsync(int cocktailId);

        Task<int> GetCocktailGlassIdAsync(int cocktailId);

        Task<bool> HasBartenderWithIdAsync(int cocktailId, string currUserId);

        Task DeleteAsync(int cocktailId);
    }
}