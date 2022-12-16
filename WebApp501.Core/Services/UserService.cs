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
    /// <summary>
    /// The UserService class responsible for dealing with user related business.
    /// </summary>
    /// <remarks>Implementation of <see cref="IUserService"/>.</remarks>
    public class UserService : IUserService
    {
        private readonly IRepository repo;
        private readonly UserManager<User> userManager;
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserService"/> class.
        /// Constructor for the statistics service class.
        /// </summary>
        /// <param name="_repo">The implementation of a repository to be used.</param>
        /// <param name="_userManager">Instance of an UserManager.</param>
        /// <param name="_mapper">Instance of an AutoMapper.</param>
        public UserService(
            IRepository _repo,
            UserManager<User> _userManager,
            IMapper _mapper)
        {
            this.repo = _repo;
            this.userManager = _userManager;
            this.mapper = _mapper;
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
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