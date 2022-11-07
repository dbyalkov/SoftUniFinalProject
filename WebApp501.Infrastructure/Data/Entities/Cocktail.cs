using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp501.Infrastructure.Data.Entities
{
    public class Cocktail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Recipe { get; set; }

        [Required]
        public string Preparation { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public int AlcoholId { get; set; }

        [ForeignKey(nameof(AlcoholId))]
        public TypeOfAlcohol Alcohol { get; set; }

        [Required]
        public int BartenderId { get; set; }

        [ForeignKey(nameof(BartenderId))]
        public Bartender Bartender { get; set; }
    }
}