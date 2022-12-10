using WebApp501.Core.Contracts;
using WebApp501.Infrastructure.Data.Common;
using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository repo;

        public UserService(IRepository _repo)
        {
            this.repo = _repo;
        }

        public async Task<string> UserNameAsync(string userId)
        {
            var user = await repo.GetByIdAsync<User>(userId);

            if (user.UserName.Contains('@'))
            {
                int startIndex = user.UserName.IndexOf('@');

                var userName = user.UserName.Remove(startIndex);

                return userName;
            }

            return user.UserName;
        }
    }
}