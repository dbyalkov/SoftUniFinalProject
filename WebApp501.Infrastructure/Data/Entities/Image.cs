using System.ComponentModel.DataAnnotations;

namespace WebApp501.Infrastructure.Data.Entities
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        public string? ImageUrl { get; set; }

        public bool IsDeleted { get; set; } = false;

        public IEnumerable<CocktailImage> ImageCocktails { get; set; } = new List<CocktailImage>();
    }
}