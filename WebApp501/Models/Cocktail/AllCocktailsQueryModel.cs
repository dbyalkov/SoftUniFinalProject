using WebApp501.Core.Models.Cocktail;

namespace WebApp501.Models.Cocktail
{
    public class AllCocktailsQueryModel
    {
        public const int CocktailsPerPage = 10;

        public string? Alcohol { get; set; }

        public string? SearchTerm { get; set; }

        public CocktailSorting Sorting { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int TotalCocktailsCount { get; set; }

        public IEnumerable<string> Alcohols { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<CocktailServiceModel> Cocktails { get; set; } = Enumerable.Empty<CocktailServiceModel>();
    }
}