using Microsoft.EntityFrameworkCore;

using WebApp501.Core.Contracts;
using WebApp501.Infrastructure.Data.Common;
using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Core.Services
{
    public class BartenderService : IBartenderService
    {
        private readonly IRepository repo;

        public BartenderService(IRepository _repo)
        {
            this.repo = _repo;
        }

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

        public async Task<bool> ExistsByIdAsync(string userId)
            => await this.repo.AllReadonly<Bartender>().AnyAsync(b => b.UserId == userId);

        public async Task<int> GetBartenderIdAsync(string userId)
            => (await this.repo.AllReadonly<Bartender>().FirstOrDefaultAsync(b => b.UserId == userId))?.Id ?? 0;

        public async Task<int> UsersCocktailsAsync(string userId)
            => await this.repo.AllReadonly<Cocktail>().CountAsync(c => c.Bartender.UserId == userId);
    }
}