using System.ComponentModel.DataAnnotations;

using static WebApp501.Infrastructure.Data.DataConstants.Glass;

namespace WebApp501.Infrastructure.Data.Entities
{
    public class Glass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;
    }
}