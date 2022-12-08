using System.ComponentModel.DataAnnotations;

using static WebApp501.Infrastructure.Data.DataConstants.Glasses;

namespace WebApp501.Infrastructure.Data.Entities
{
    public class Glass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public bool IsDeleted { get; set; } = false;

        public IEnumerable<Cocktail> Cocktails { get; set; } = new List<Cocktail>();
    }
}