using WebApp501.Core.Models.Cocktail;

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

        Task<IEnumerable<CocktailServiceModel>> AllCocktailsByBartenderId(int id);

        Task<CocktailServiceModel> CocktailDetailsById(int id);

        Task<bool> Exists(int id);

        Task Edit(int cocktailId, CocktailFormModel model);

        Task<int> GetCocktailAlcoholIdAsync(int cocktailId);

        Task<int> GetCocktailGlassIdAsync(int cocktailId);

        Task Delete(int cocktailId);
    }
}