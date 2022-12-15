using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static WebApp501.Infrastructure.Data.DataConstants.Cocktails;

namespace WebApp501.Infrastructure.Data.Entities
{
    /// <summary>
    /// The database model for cocktails.
    /// </summary>
    public class Cocktail
    {
        /// <summary>
        /// Gets or sets a unique identifier for a cocktail.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the cocktail.
        /// </summary>
        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the recipe of the cocktail.
        /// </summary>
        [Required]
        [MaxLength(MaxRecipeLength)]
        public string Recipe { get; set; } = null!;

        /// <summary>
        /// Gets or sets the preparation of the cocktail.
        /// </summary>
        [Required]
        [MaxLength(MaxPreparationLength)]
        public string Preparation { get; set; } = null!;

        /// <summary>
        /// Gets or sets the id of the alcohol which the cocktail contains.
        /// </summary>
        [Required]
        public int AlcoholId { get; set; }

        /// <summary>
        /// Gets or sets the alcohol which the cocktail contains.
        /// </summary>
        /// <remarks>Foreign key to the "Alcohols" table.</remarks>
        [ForeignKey(nameof(AlcoholId))]
        public TypeOfAlcohol Alcohol { get; set; } = null!;

        /// <summary>
        /// Gets or sets the id of the bartender who created the cocktail.
        /// </summary>
        [Required]
        public int BartenderId { get; set; }

        /// <summary>
        /// Gets or sets the bartender who created the cocktail.
        /// </summary>
        /// <remarks>Foreign key to the "Bartenders" table.</remarks>
        [ForeignKey(nameof(BartenderId))]
        public Bartender Bartender { get; set; } = null!;

        /// <summary>
        /// Gets or sets the id of the glass in which the cocktail can be served.
        /// </summary>
        public int GlassId { get; set; }

        /// <summary>
        /// Gets or sets the glass in which the cocktail can be served.
        /// </summary>
        /// <remarks>Foreign key to the "Glasses" table.</remarks>
        [ForeignKey(nameof(GlassId))]
        public Glass Glass { get; set; } = null!;

        /// <summary>
        /// Gets or sets the image which the cocktail has.
        /// </summary>
        /// <remarks>Navigational property.</remarks>
        public Image Image { get; set; } = null!;

        /// <summary>
        /// Gets or sets a value indicating whether the cocktail has been deleted.
        /// </summary>
        public bool IsDeleted { get; set; } = false;
    }
}