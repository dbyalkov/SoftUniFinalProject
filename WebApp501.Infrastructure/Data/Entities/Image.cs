using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp501.Infrastructure.Data.Entities
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        public string ImageUrl { get; set; } = null!;

        [Required]
        public int CocktailId { get; set; }

        [ForeignKey(nameof(CocktailId))]
        public Cocktail Cocktail { get; set; } = null!;

        public bool IsDeleted { get; set; } = false;
    }
}