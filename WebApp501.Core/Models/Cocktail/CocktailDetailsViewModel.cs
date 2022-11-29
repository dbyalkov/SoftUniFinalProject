namespace WebApp501.Core.Models.Cocktail
{
    public class CocktailDetailsViewModel
    {
        public string Name { get; set; } = null!;

        public string Recipe { get; set; } = null!;

        public string Preparation { get; set; } = null!;

        public string? ImageUrl { get; set; }
    }
}