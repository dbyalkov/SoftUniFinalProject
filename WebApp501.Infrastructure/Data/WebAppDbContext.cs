using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using WebApp501.Infrastructure.Data.Configuration;
using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Infrastructure.Data
{
    public class WebAppDbContext : IdentityDbContext<User>
    {
        public WebAppDbContext(DbContextOptions<WebAppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new ImageConfiguration());
            builder.ApplyConfiguration(new AlcoholConfiguration());
            builder.ApplyConfiguration(new BartenderConfiguration());
            builder.ApplyConfiguration(new GlassConfiguration());
            builder.ApplyConfiguration(new CocktailConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Image> Images { get; set; } = null!;

        public DbSet<Bartender> Bartenders { get; set; } = null!;

        public DbSet<Cocktail> Cocktails { get; set; } = null!;

        public DbSet<Glass> Glasses { get; set; } = null!;

        public DbSet<TypeOfAlcohol> Alcohols { get; set; } = null!;
    }
}