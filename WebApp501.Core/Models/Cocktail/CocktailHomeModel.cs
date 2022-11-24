namespace WebApp501.Core.Models.Cocktail
{
    public class CocktailHomeModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? ImageUrl { get; set; }
    }
}