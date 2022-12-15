using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using WebApp501.Infrastructure.Data.Configuration;
using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Infrastructure.Data
{
    /// <summary>
    /// The database context for the app.
    /// </summary>
    public class WebAppDbContext : IdentityDbContext<User>
    {
        private bool seedDb;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebAppDbContext"/> class.
        /// Constructor for the EasyRank database context.
        /// </summary>
        /// <param name="options">Options for the database.</param>
        /// <param name="isSeed">Should the database be seeded.</param>
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
            /// <summary>
            /// Fluent API configuration for the "Cocktail" model.
            /// </summary>
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
                // Apply the "User" entity model configuration.
                builder.ApplyConfiguration(new UserConfiguration());

                // Apply the "Image" entity model configuration.
                builder.ApplyConfiguration(new ImageConfiguration());

                // Apply the "Alcohol" entity model configuration.
                builder.ApplyConfiguration(new AlcoholConfiguration());

                // Apply the "Bartender" entity model configuration.
                builder.ApplyConfiguration(new BartenderConfiguration());

                // Apply the "Glass" entity model configuration.
                builder.ApplyConfiguration(new GlassConfiguration());

                // Apply the "Cocktail" entity model configuration.
                builder.ApplyConfiguration(new CocktailConfiguration());
            }

            base.OnModelCreating(builder);
        }

        /// <summary>
        /// Gets or sets the "Images" table from the database.
        /// </summary>
        public DbSet<Image> Images { get; set; } = null!;

        /// <summary>
        /// Gets or sets the "Bartenders" table from the database.
        /// </summary>
        public DbSet<Bartender> Bartenders { get; set; } = null!;

        /// <summary>
        /// Gets or sets the "Cocktails" table from the database.
        /// </summary>
        public DbSet<Cocktail> Cocktails { get; set; } = null!;

        /// <summary>
        /// Gets or sets the "Glasses" table from the database.
        /// </summary>
        public DbSet<Glass> Glasses { get; set; } = null!;

        /// <summary>
        /// Gets or sets the "Alcohols" table from the database.
        /// </summary>
        public DbSet<TypeOfAlcohol> Alcohols { get; set; } = null!;
    }
}