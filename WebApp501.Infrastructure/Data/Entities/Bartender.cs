using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static WebApp501.Infrastructure.Data.DataConstants.Bartenders;

namespace WebApp501.Infrastructure.Data.Entities
{
    /// <summary>
    /// The database model for bartender.
    /// </summary>
    public class Bartender
    {
        /// <summary>
        /// Gets or sets a unique identifier for a cocktail.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name of the bartender.
        /// </summary>
        [Required]
        [MaxLength(MaxFirstNameLength)]
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the last name of the bartender.
        /// </summary>
        [Required]
        [MaxLength(MaxLastNameLength)]
        public string LastName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the age of the bartender.
        /// </summary>
        [Required]
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the id of the user who has become a bartender.
        /// </summary>
        [Required]
        public string UserId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the user who has become a bartender.
        /// </summary>
        /// <remarks>Foreign key to the "AspNetUsers" table.</remarks>
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        /// <summary>
        /// Gets or sets every cocktail which the particular bartender has created.
        /// </summary>
        public IEnumerable<Cocktail> Cocktails { get; set; } = new List<Cocktail>();
    }
}