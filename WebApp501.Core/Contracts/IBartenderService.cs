namespace WebApp501.Core.Contracts
{
    /// <summary>
    /// The interface for the BartenderService.
    /// </summary>
    public interface IBartenderService
    {
        /// <summary>
        /// Checks if a bartender with this "userId" exists.
        /// </summary>
        /// <param name="userId">String used for checking the specified user.</param>
        /// <returns>True or False.</returns>
        Task<bool> ExistsByIdAsync(string userId);

        /// <summary>
        /// Gets the number of the cocktails created by the specified bartender.
        /// </summary>
        /// <param name="bartenderId">Int used for getting the needed bartender.</param>
        /// <returns>Number of created cocktails.</returns>
        Task<int> BartenderCocktailsAsync(int bartenderId);

        /// <summary>
        /// Creates a bartender, adds it to the database and saves the changes.
        /// </summary>
        /// <param name="userId">String used to search for the needed user.</param>
        /// <param name="firstName">Bartender's first name.</param>
        /// <param name="lastName">Bartender's last name.</param>
        /// <param name="age">Bartender's age.</param>
        /// <returns>Task (void)</returns>
        Task CreateAsync(string userId, string firstName, string lastName, int age);

        /// <summary>
        /// Gets the Id of the specified user.
        /// </summary>
        /// <param name="userId">String used to search for the needed user.</param>
        /// <returns>Bartender's Id</returns>
        Task<int> GetBartenderIdAsync(string userId);
    }
}