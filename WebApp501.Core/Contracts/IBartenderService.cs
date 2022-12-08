namespace WebApp501.Core.Contracts
{
    public interface IBartenderService
    {
        Task<bool> ExistsByIdAsync(string userId);

        Task<int> UsersCocktailsAsync(string userId);

        Task CreateAsync(string userId, string firstName, string lastName, int age);

        Task<int> GetBartenderIdAsync(string userId);
    }
}