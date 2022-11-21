using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static WebApp501.Infrastructure.Data.DataConstants.Cocktail;

namespace WebApp501.Infrastructure.Data.Entities
{
    public class Cocktail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(MaxRecipeLength)]
        public string Recipe { get; set; } = null!;

        [Required]
        [MaxLength(MaxPreparationLength)]
        public string Preparation { get; set; } = null!;

        public int? ImageId { get; set; }

        [ForeignKey(nameof(ImageId))]
        public Image? Image { get; set; }

        [Required]
        public int AlcoholId { get; set; }

        [ForeignKey(nameof(AlcoholId))]
        public TypeOfAlcohol Alcohol { get; set; } = null!;

        [Required]
        public int BartenderId { get; set; }

        [ForeignKey(nameof(BartenderId))]
        public Bartender Bartender { get; set; } = null!;

        public int? GlassId { get; set; }

        [ForeignKey(nameof(GlassId))]
        public Glass? Glass { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}