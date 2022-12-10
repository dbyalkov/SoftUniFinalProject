using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static WebApp501.Infrastructure.Data.DataConstants.Bartenders;

namespace WebApp501.Infrastructure.Data.Entities
{
    public class Bartender
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxFirstNameLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(MaxLastNameLength)]
        public string LastName { get; set; } = null!;

        [Required]
        public int Age { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        public bool IsDeleted { get; set; } = false;

        public IEnumerable<Cocktail> Cocktails { get; set; } = new List<Cocktail>();
    }
}