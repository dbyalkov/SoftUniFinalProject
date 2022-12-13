using Microsoft.EntityFrameworkCore;

using WebApp501.Infrastructure.Data;

namespace WebApp501.Tests.Common.Mocks
{
    public static class DatabaseMock
    {
        public static WebAppDbContext Instance
        {
            get
            {
                var contextOptions = new DbContextOptionsBuilder<WebAppDbContext>()
                .UseInMemoryDatabase($"CocktailDb-TestDb-{DateTime.Now.Ticks}")
                .Options;

                return new WebAppDbContext(contextOptions, false);
            }
        }
    }
}