using System.ComponentModel.DataAnnotations;

using static WebApp501.Infrastructure.Data.DataConstants.Glasses;

namespace WebApp501.Infrastructure.Data.Entities
{
    /// <summary>
    /// The database model for glass.
    /// </summary>
    public class Glass
    {
        /// <summary>
        /// Gets or sets a unique identifier for an image.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the glass.
        /// </summary>
        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the image url of the glass.
        /// </summary>
        public string ImageUrl { get; set; } = null!;

        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// Gets or sets every cocktail which can be served in the particular glass.
        /// </summary>
        public IEnumerable<Cocktail> Cocktails { get; set; } = new List<Cocktail>();
    }
}