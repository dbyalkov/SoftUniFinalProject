using System.ComponentModel.DataAnnotations;

using static WebApp501.Infrastructure.Data.DataConstants.Alcohols;

namespace WebApp501.Infrastructure.Data.Entities
{
    /// <summary>
    /// The database model for types of alcohol.
    /// </summary>
    public class TypeOfAlcohol
    {
        /// <summary>
        /// Gets or sets a unique identifier for a type of alcohol.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the alcohol.
        /// </summary>
        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// Gets or sets every cocktail which contains the particular type of alcohol.
        /// </summary>
        public IEnumerable<Cocktail> Cocktails { get; set; } = new List<Cocktail>();
    }
}