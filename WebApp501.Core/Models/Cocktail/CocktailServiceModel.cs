using System.ComponentModel.DataAnnotations;

namespace WebApp501.Core.Models.Cocktail
{
    public class CocktailServiceModel : ICocktailModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Recipe { get; set; } = null!;

        [Required]
        public string Preparation { get; set; } = null!;

        [Required]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;
    }
}