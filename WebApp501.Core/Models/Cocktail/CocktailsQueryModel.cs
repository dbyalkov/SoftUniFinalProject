namespace WebApp501.Core.Models.Cocktail
{
    public class CocktailsQueryModel
    {
        public int TotalCocktailsCount { get; set; }

        public IEnumerable<CocktailServiceModel> Cocktails { get; set; } = new List<CocktailServiceModel>();
    }
}