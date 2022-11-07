using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.AspNetCore.Identity;

namespace WebApp501.Infrastructure.Data.Entities
{
    public class Bartender
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
    }
}