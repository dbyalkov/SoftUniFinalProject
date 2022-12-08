using System.ComponentModel.DataAnnotations;

using static WebApp501.Infrastructure.Data.DataConstants.Cocktails;

namespace WebApp501.Core.Models.Cocktail
{
    public class CocktailFormModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        [MinLength(MinNameLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(MaxRecipeLength)]
        [MinLength(MinRecipeLength)]
        public string Recipe { get; set; } = null!;

        [Required]
        [MaxLength(MaxPreparationLength)]
        [MinLength(MinPreparationLength)]
        public string Preparation { get; set; } = null!;

        [Required]
        [Display(Name = "Alcohol")]
        public int AlcoholId { get; set; }

        [Display(Name = "Glass")]
        public int GlassId { get; set; }

        [Display(Name = "ImageUrl")]
        public string Image { get; set; } = null!;

        public IEnumerable<CocktailAlcoholServiceModel> Alcohols { get; set; } = new List<CocktailAlcoholServiceModel>();

        public IEnumerable<CocktailGlassServiceModel> Glasses { get; set; } = new List<CocktailGlassServiceModel>();
    }
}