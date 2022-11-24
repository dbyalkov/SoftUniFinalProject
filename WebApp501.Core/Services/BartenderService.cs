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
            repo = _repo;
        }

        public async Task Create(string userId, string firstName, string lastName, int age)
        {
            var bartender = new Bartender()
            {
                UserId = userId,
                FirstName = firstName,
                LastName = lastName,
                Age = age
            };

            await repo.AddAsync(bartender);
            await repo.SaveChangesAsync();
        }

        public async Task<bool> ExistsById(string userId)
        {
            return await repo.All<Bartender>()
                .AnyAsync(b => b.UserId == userId);
        }

        public async Task<int> GetBartenderId(string userId)
        {
            return (await repo.AllReadonly<Bartender>()
                .FirstOrDefaultAsync(b => b.UserId == userId))?.Id ?? 0;
        }

        public async Task<bool> UserHasCocktails(string userId)
        {
            return await repo.All<Cocktail>()
                .AnyAsync(c => c.Bartender.UserId == userId);
        }

        public async Task<bool> UserWithEmailExists(string userEmail)
        {
            return await repo.All<Bartender>()
                .AnyAsync(b => b.User.Email == userEmail);
        }
    }
}