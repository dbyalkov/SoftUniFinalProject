namespace WebApp501.Core.Models.User
{
    public class UserServiceModel
    {
        public string UserId { get; init; } = null!;

        public string Email { get; init; } = null!;

        public string? FullName { get; init; } = null;

        public int Age { get; set; }

        public bool IsDeleted { get; set; }
    }
}