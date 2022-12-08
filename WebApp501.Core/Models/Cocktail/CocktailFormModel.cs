using System.ComponentModel.DataAnnotations;

using WebApp501.Infrastructure.Data.Entities;

using static WebApp501.Infrastructure.Data.DataConstants.Cocktail;

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
        [Display(Name = "Bartender")]
        public int BartenderId { get; set; }

        [Required]
        [Display(Name = "Alcohol")]
        public int AlcoholId { get; set; }

        [Display(Name = "Glass")]
        public int? GlassId { get; set; }        

        public Image? Image { get; set; }

        public IEnumerable<CocktailAlcoholModel> CocktailAlcohols { get; set; } = new List<CocktailAlcoholModel>();
    }
}