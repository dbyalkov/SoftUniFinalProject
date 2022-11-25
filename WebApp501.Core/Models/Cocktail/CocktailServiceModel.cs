using System.ComponentModel.DataAnnotations;

namespace WebApp501.Core.Models.Cocktail
{
    public class CocktailServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Recipe { get; set; } = null!;

        public string Preparation { get; set; } = null!;

        [Display(Name = "Image")]
        public string? ImageUrl { get; set; }
    }
}