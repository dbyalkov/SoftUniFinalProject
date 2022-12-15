using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Identity;

using static WebApp501.Infrastructure.Data.DataConstants.Users;

namespace WebApp501.Infrastructure.Data.Entities
{
    /// <summary>
    /// The main user class used for application users.
    /// </summary>
    public class User : IdentityUser
    {
        /// <summary>
        /// Gets or sets the middle name for a user.
        /// </summary>
        [MaxLength(MaxMiddleNameLength)]
        public string? MiddleName { get; set; } = null;

        /// <summary>
        /// Gets or sets a value indicating whether the user has been deleted (forgotten).
        /// </summary>
        public bool IsDeleted { get; set; } = false;
    }
}