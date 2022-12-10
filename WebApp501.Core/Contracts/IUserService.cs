namespace WebApp501.Core.Contracts
{
    public interface IUserService
    {
        Task<string> UserNameAsync(string userid);
    }
}