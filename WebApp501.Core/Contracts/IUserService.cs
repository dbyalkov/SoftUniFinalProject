using WebApp501.Core.Models.User;

namespace WebApp501.Core.Contracts
{
    public interface IUserService
    {
        Task<string> UserNameAsync(string userid);

        Task<IEnumerable<UserServiceModel>> All();
    }
}