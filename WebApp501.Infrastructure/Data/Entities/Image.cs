using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp501.Infrastructure.Data.Entities
{
    /// <summary>
    /// The database model for images.
    /// </summary>
    public class Image
    {
        /// <summary>
        /// Gets or sets a unique identifier for an image.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the image url of the image.
        /// </summary>
        public string ImageUrl { get; set; } = null!;

        /// <summary>
        /// Gets or sets the id of the cocktail to which this image is.
        /// </summary>
        [Required]
        public int CocktailId { get; set; }

        /// <summary>
        /// Gets or sets the cocktail to which this image is.
        /// </summary>
        /// <remarks>Foreign key to the "Cocktail" table.</remarks>
        [ForeignKey(nameof(CocktailId))]
        public Cocktail Cocktail { get; set; } = null!;

        public bool IsDeleted { get; set; } = false;
    }
}