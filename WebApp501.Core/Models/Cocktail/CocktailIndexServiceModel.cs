namespace WebApp501.Core.Models.Cocktail
{
    public class CocktailIndexServiceModel : ICocktailModel
    {
        public int Id { get; init; }

        public string Name { get; init; } = null!;

        public string ImageUrl { get; init; } = null!;

        public string Recipe { get; init; } = null!;

        public string Preparation { get; init; } = null!;
    }
}