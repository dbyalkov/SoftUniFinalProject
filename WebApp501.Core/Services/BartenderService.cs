using Microsoft.EntityFrameworkCore;

using WebApp501.Core.Contracts;
using WebApp501.Infrastructure.Data.Common;
using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Core.Services
{
    /// <summary>
    /// The BartenderService class responsible for dealing with bartender related business.
    /// </summary>
    /// <remarks>Implementation of <see cref="IBartenderService"/>.</remarks>
    public class BartenderService : IBartenderService
    {
        private readonly IRepository repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="BartenderService"/> class.
        /// Constructor for the bartender service class.
        /// </summary>
        /// <param name="_repo">The implementation of a repository to be used.</param>
        public BartenderService(IRepository _repo)
        {
            this.repo = _repo;
        }

        /// <inheritdoc />
        public async Task CreateAsync(string userId, string firstName, string lastName, int age)
        {
            var bartender = new Bartender()
            {
                UserId = userId,
                FirstName = firstName,
                LastName = lastName,
                Age = age
            };

            await this.repo.AddAsync(bartender);
            await this.repo.SaveChangesAsync();
        }

        /// <inheritdoc />
        public async Task<bool> ExistsByIdAsync(string userId)
            => await this.repo.AllReadonly<Bartender>().AnyAsync(b => b.UserId == userId);

        /// <inheritdoc />
        public async Task<int> GetBartenderIdAsync(string userId)
            => (await this.repo.AllReadonly<Bartender>().FirstOrDefaultAsync(b => b.UserId == userId))?.Id ?? 0;

        /// <inheritdoc />
        public async Task<int> BartenderCocktailsAsync(int bartenderId)
            => await this.repo.AllReadonly<Cocktail>().CountAsync(c => c.Bartender.Id == bartenderId);
    }
}