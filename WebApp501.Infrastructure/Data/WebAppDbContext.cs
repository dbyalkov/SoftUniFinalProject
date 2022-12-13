using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using WebApp501.Infrastructure.Data.Configuration;
using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Infrastructure.Data
{
    public class WebAppDbContext : IdentityDbContext<User>
    {
        private bool seedDb;

        public WebAppDbContext(DbContextOptions<WebAppDbContext> options, bool seed = true)
            : base(options)
        {
            if (!this.Database.IsRelational())
            {
                this.Database.EnsureCreated();
            }

            this.seedDb = seed;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Cocktail>()
                .HasOne(c => c.Image)
                .WithOne(i => i.Cocktail)
                .HasForeignKey<Image>(i => i.CocktailId);

            builder
                .Entity<Cocktail>()
                .HasOne(c => c.Alcohol)
                .WithMany(a => a.Cocktails)
                .HasForeignKey(c => c.AlcoholId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<Cocktail>()
                .HasOne(c => c.Bartender)
                .WithMany(b => b.Cocktails)
                .HasForeignKey(c => c.BartenderId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<Cocktail>()
                .HasOne(c => c.Glass)
                .WithMany(g => g.Cocktails)
                .HasForeignKey(c => c.GlassId)
                .OnDelete(DeleteBehavior.NoAction);

            if (this.seedDb)
            {
                builder.ApplyConfiguration(new UserConfiguration());
                builder.ApplyConfiguration(new ImageConfiguration());
                builder.ApplyConfiguration(new AlcoholConfiguration());
                builder.ApplyConfiguration(new BartenderConfiguration());
                builder.ApplyConfiguration(new GlassConfiguration());
                builder.ApplyConfiguration(new CocktailConfiguration());
            }

            base.OnModelCreating(builder);
        }

        public DbSet<Image> Images { get; set; } = null!;

        public DbSet<Bartender> Bartenders { get; set; } = null!;

        public DbSet<Cocktail> Cocktails { get; set; } = null!;

        public DbSet<Glass> Glasses { get; set; } = null!;

        public DbSet<TypeOfAlcohol> Alcohols { get; set; } = null!;
    }
}