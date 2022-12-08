using WebApp501.Core.Models.Cocktail;

namespace WebApp501.Models.Cocktail
{
    public class AllCocktailsQueryModel
    {
        public const int CocktailsPerPage = 3;

        public string? Alcohol { get; init; }

        public string? Glass { get; init; }

        public string? SearchTerm { get; init; }

        public CocktailSorting Sorting { get; init; }

        public int CurrentPage { get; init; } = 1;

        public int TotalCocktailsCount { get; set; }

        public IEnumerable<string> Alcohols { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> Glasses { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<CocktailServiceModel> Cocktails { get; set; } = Enumerable.Empty<CocktailServiceModel>();
    }
}