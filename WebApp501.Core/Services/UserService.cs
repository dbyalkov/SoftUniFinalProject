using AutoMapper;
using AutoMapper.QueryableExtensions;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using WebApp501.Core.Contracts;
using WebApp501.Core.Models.User;
using WebApp501.Infrastructure.Data.Common;
using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository repo;
        private readonly UserManager<User> userManager;
        private readonly IMapper mapper;

        public UserService(
            IRepository _repo,
            UserManager<User> _userManager,
            IMapper _mapper)
        {
            this.repo = _repo;
            this.userManager = _userManager;
            this.mapper = _mapper;
        }

        public async Task<IEnumerable<UserServiceModel>> All()
        {
            List<UserServiceModel> result;

            result = await this.repo.AllReadonly<Bartender>()
                .Include(b => b.User)
                .ProjectTo<UserServiceModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

            string[] bartendersIds = result.Select(b => b.UserId).ToArray();

            result.AddRange(await this.repo.AllReadonly<User>()
                .Where(u => !bartendersIds.Contains(u.Id))
                .ProjectTo<UserServiceModel>(this.mapper.ConfigurationProvider)
                .ToListAsync());

            return result;
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

        public async Task<bool> Forget(string userId)
        {
            var user = await this.userManager.FindByIdAsync(userId);

            user.UserName = $"forgottenUser-{DateTime.Now.Ticks}";
            user.NormalizedUserName = null;
            user.Email = null;
            user.NormalizedEmail = null;
            user.PasswordHash = null;
            user.MiddleName = null;
            user.IsDeleted = true;

            var result = await this.userManager.UpdateAsync(user);

            return result.Succeeded;
        }
    }
}