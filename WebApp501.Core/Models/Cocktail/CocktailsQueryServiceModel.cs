namespace WebApp501.Core.Models.Cocktail
{
    public class CocktailsQueryServiceModel
    {
        public int TotalCocktailsCount { get; set; }

        public IEnumerable<CocktailServiceModel> Cocktails { get; set; } = new List<CocktailServiceModel>();
    }
}