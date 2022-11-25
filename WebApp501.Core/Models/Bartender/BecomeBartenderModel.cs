using System.ComponentModel.DataAnnotations;

using static WebApp501.Infrastructure.Data.DataConstants.Bartender;

namespace WebApp501.Core.Models.Bartender
{
    public class BecomeBartenderModel
    {
        [Required]
        [MaxLength(MaxFirstNameLength)]
        [MinLength(MinFirstNameLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(MaxLastNameLength)]
        [MinLength(MinLastNameLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [Range(18, 99, ErrorMessage = "Age must be between {1} and {2}.")]
        public int Age { get; set; }
    }
}