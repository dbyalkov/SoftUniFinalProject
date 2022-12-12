using System.ComponentModel.DataAnnotations;

using static WebApp501.Infrastructure.Data.DataConstants.Bartenders;

namespace WebApp501.Web.Models.Bartender
{
    public class BecomeBartenderFormModel
    {
        [Required]
        [MaxLength(MaxFirstNameLength)]
        [MinLength(MinFirstNameLength)]
        [Display(Name = "First Name")]
        public string FirstName { get; init; } = null!;

        [Required]
        [MaxLength(MaxLastNameLength)]
        [MinLength(MinLastNameLength)]
        [Display(Name = "Last Name")]
        public string LastName { get; init; } = null!;

        [Required]
        [Range(MinAge, 99, ErrorMessage = "Age must be between {1} and {2}.")]
        public int Age { get; init; }
    }
}