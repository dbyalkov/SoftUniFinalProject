namespace WebApp501.Core.Contracts
{
    public interface IBartenderService
    {
        Task<bool> ExistsById(string userId);

        Task<bool> UserWithUserNameExists(string userName);

        Task<bool> UserHasCocktails(string userId);

        Task Create(string userId, string firstName, string lastName, int age);

        Task<int> GetBartenderId(string userId);
    }
}