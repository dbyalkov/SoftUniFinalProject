using WebApp501.Core.Models.User;

namespace WebApp501.Core.Contracts
{
    /// <summary>
    /// The interface for the UserService.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Used for retrieving a collection of all users.
        /// </summary>
        /// <returns>A collection of user service models.</returns>
        Task<IEnumerable<UserServiceModel>> All();

        /// <summary>
        /// Used for retrieving the user name of a specified user.
        /// </summary>
        /// <param name="userid">String used for getting the needed user.</param>
        /// <returns>The user name of a specified user.</returns>
        Task<string> UserNameAsync(string userid);

        /// <summary>
        /// Used to "forget" a specified user.
        /// </summary>
        /// <param name="userId">String used for checking the specified user.</param>
        /// <returns>True or False</returns>
        /// <remarks>Sets a "IsDeleted" flag. Doesn't actually delete, but sets to null all selected properties.</remarks>
        Task<bool> Forget(string userId);
    }
}