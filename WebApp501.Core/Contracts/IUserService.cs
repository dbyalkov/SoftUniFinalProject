using WebApp501.Core.Models.User;

namespace WebApp501.Core.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<UserServiceModel>> All();

        Task<string> UserNameAsync(string userid);

        Task<bool> Forget(string userId);
    }
}