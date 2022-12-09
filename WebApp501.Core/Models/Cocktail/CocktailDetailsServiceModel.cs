using WebApp501.Core.Models.Bartender;

namespace WebApp501.Core.Models.Cocktail
{
    public class CocktailDetailsServiceModel : CocktailServiceModel
    {
        public string Alcohol { get; init; } = null!;

        public string Glass { get; init; } = null!;

        public BartenderServiceModel Bartender { get; init; } = null!;
    }
}