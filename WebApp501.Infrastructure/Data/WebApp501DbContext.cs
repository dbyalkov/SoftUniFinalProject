using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Infrastructure
{
    public class WebApp501DbContext : IdentityDbContext
    {
        public WebApp501DbContext(DbContextOptions<WebApp501DbContext> options)
            : base(options)
        {
        }

        public DbSet<AlcoholCocktail> AlcoholsCocktails { get; set; }

        public DbSet<Bartender> Bartenders { get; set; }

        public DbSet<Cocktail> Cocktails { get; set; }

        public DbSet<Glass> Glasses { get; set; }

        public DbSet<TypeOfAlcohol> Alcohols { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}