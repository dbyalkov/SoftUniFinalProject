using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Identity;

using static WebApp501.Infrastructure.Data.DataConstants.Users;

namespace WebApp501.Infrastructure.Data.Entities
{
    public class User : IdentityUser
    {
        [MaxLength(MaxMiddleNameLength)]
        public string? MiddleName { get; init; } = null;
    }
}