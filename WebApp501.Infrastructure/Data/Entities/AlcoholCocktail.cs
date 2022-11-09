using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp501.Infrastructure.Data.Entities
{
    public class AlcoholCocktail
    {
        [Required]
        public int AlcoholId { get; set; }

        [ForeignKey(nameof(AlcoholId))]
        public TypeOfAlcohol Alcohol { get; set; } = null!;

        [Required]
        public int CocktailId { get; set; }

        [ForeignKey(nameof(CocktailId))]
        public Cocktail Cocktail { get; set; } = null!;
    }
}