using WebApp501.Core.Models.Bartender;

namespace WebApp501.Core.Models.Cocktail
{
    public class CocktailDetailsModel : CocktailServiceModel
    {
        public string Alcohol { get; set; } = null!;

        public BartenderServiceModel Bartender { get; set; }
    }
}