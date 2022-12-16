using WebApp501.Core.Models.Cocktail;

namespace WebApp501.Core.Contracts
{
    /// <summary>
    /// The interface for the CocktailService.
    /// </summary>
    public interface ICocktailService
    {
        /// <summary>
        /// Used for retrieving a collection of the last ten created/added cocktails.
        /// </summary>
        /// <returns>A collection of cocktail index service models.</returns>
        Task<IEnumerable<CocktailIndexServiceModel>> LastTenCocktailsAsync();

        /// <summary>
        /// Used for retrieving a collection of all types of alcohol.
        /// </summary>
        /// <returns>A collection of cocktail alcohol service models.</returns>
        Task<IEnumerable<CocktailAlcoholServiceModel>> AllTypesOfAlcoholAsync();

        /// <summary>
        /// Used for retrieving a collection of all glasses in which a cocktail can be served.
        /// </summary>
        /// <returns>A collection of cocktail glass service models.</returns>
        Task<IEnumerable<CocktailGlassServiceModel>> AllGlassesAsync();

        /// <summary>
        /// Checks if an alcohol with this "alcoholId" exists.
        /// </summary>
        /// <param name="alcoholId">Int used for checking the specified alcohol.</param>
        /// <returns>True or False</returns>
        Task<bool> AlcoholExistsAsync(int alcoholId);

        /// <summary>
        /// Checks if a glass with this "glassId" exists.
        /// </summary>
        /// <param name="glassId">Int used for checking the specified glass.</param>
        /// <returns>True or False</returns>
        Task<bool> GlassExistsAsync(int glassId);

        /// <summary>
        /// Creates a cocktail, adds it to the database, saves the changes and returns the created cocktail's Id.
        /// </summary>
        /// <param name="model">A model in which, the bartender adds data that specifies the added/created cocktail.</param>
        /// <param name="bartenderId">Int used to search for the needed bartender.</param>
        /// <returns>The Id of the added/created cocktail.</returns>
        Task<int> CreateAsync(CocktailFormModel model, int bartenderId);

        /// <summary>
        /// Used for retrieving a collection of cocktails which meet a specific search.
        /// </summary>
        /// <param name="alcohol">Select an alcohol and get only the cocktails containing the given alcohol.</param>
        /// <param name="glass">Select a glass and get only the cocktails which can be served in the given glass.</param>
        /// <param name="searchTerm">Use a search term and get only the cocktails which match the given term.</param>
        /// <param name="sorting">Select one of the given options and the collection will sort according it.</param>
        /// <param name="currentPage">Int used for the current page.</param>
        /// <param name="cocktailsPerPage">Int used for the number of cocktails per page.</param>
        /// <returns>A cocktails query service model.</returns>
        Task<CocktailsQueryServiceModel> AllAsync(
            string? alcohol = null,
            string? glass = null,
            string? searchTerm = null,
            CocktailSorting sorting = CocktailSorting.Newest,
            int currentPage = 1,
            int cocktailsPerPage = 1);

        /// <summary>
        /// Used for retrieving a collection of all types of alcohol names.
        /// </summary>
        /// <returns>A collection of strings.</returns>
        Task<IEnumerable<string>> AllAlcoholsNamesAsync();

        /// <summary>
        /// Used for retrieving a collection of all glasses names.
        /// </summary>
        /// <returns>A collection of strings.</returns>
        Task<IEnumerable<string>> AllGlassesNamesAsync();

        /// <summary>
        /// Used for retrieving a collection of all cocktails by a specified bartender.
        /// </summary>
        /// <param name="id">Int used for bartender's Id.</param>
        /// <returns>A collection of cocktail service models.</returns>
        Task<IEnumerable<CocktailServiceModel>> AllCocktailsByBartenderIdAsync(int id);

        /// <summary>
        /// Used for retrieving a cocktail's details.
        /// </summary>
        /// <param name="id">Int used for cocktail's Id.</param>
        /// <returns>A cocktail details service model.</returns>
        Task<CocktailDetailsServiceModel> CocktailDetailsByIdAsync(int id);

        /// <summary>
        /// Checks if a cocktail with this "id" exists.
        /// </summary>
        /// <param name="id">Int used for cocktail's Id.</param>
        /// <returns>True or False</returns>
        Task<bool> ExistsAsync(int id);

        /// <summary>
        /// Edits the cocktail and saves it back to the database.
        /// </summary>
        /// <param name="cocktailId">Int used for cocktail's Id.</param>
        /// <param name="model">A model in which, the bartender edits data that regarding the selected cocktail.</param>
        /// <returns>Task (void)</returns>
        Task EditAsync(int cocktailId, CocktailFormModel model);

        /// <summary>
        /// Used for retrieving a cocktail's alcohol Id.
        /// </summary>
        /// <param name="cocktailId">Int used for cocktail's Id.</param>
        /// <returns>An alcohol's Id.</returns>
        Task<int> GetCocktailAlcoholIdAsync(int cocktailId);

        /// <summary>
        /// Used for retrieving a cocktail's glass Id.
        /// </summary>
        /// <param name="cocktailId">Int used for cocktail's Id.</param>
        /// <returns>A glass's Id.</returns>
        Task<int> GetCocktailGlassIdAsync(int cocktailId);

        /// <summary>
        /// Checks if a user with this "id" is a bartender.
        /// </summary>
        /// <param name="cocktailId">Int used for cocktail's Id.</param>
        /// <param name="currUserId">String used for user's Id.</param>
        /// <returns>True or False</returns>
        Task<bool> HasBartenderWithIdAsync(int cocktailId, string currUserId);

        /// <summary>
        /// Deletes a cocktial from the database.
        /// </summary>
        /// <param name="cocktailId">Int used for cocktail's Id.</param>
        /// <returns>Task (void)</returns>
        /// <remarks>Sets a "IsDeleted" flag. Doesn't actually delete.</remarks>
        Task DeleteAsync(int cocktailId);
    }
}