namespace WebApp501.Infrastructure.Data.Entities
{
    public class CocktailImage
    {
        public int CocktailId { get; set; }
        public Cocktail Cocktail { get; set; }

        public int ImageId { get; set; }
        public Image Image { get; set; }
    }
}