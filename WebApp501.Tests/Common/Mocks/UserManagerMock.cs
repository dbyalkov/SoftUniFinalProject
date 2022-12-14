using Microsoft.AspNetCore.Identity;

using Moq;

using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Tests.Common.Mocks
{
    public class UserManagerMock
    {
        public static Mock<UserManager<User>> MockUserManager(List<User> userList)
        {
            Mock<UserManager<User>> userManager = new Mock<UserManager<User>>(
                Mock.Of<IUserStore<User>>(),
                null, null, null, null, null, null, null, null);

            userManager.Object.UserValidators.Add(new UserValidator<User>());
            userManager.Object.PasswordValidators.Add(new PasswordValidator<User>());

            userManager.Setup(um => um
                .FindByIdAsync(It.IsAny<string>()))!
                .ReturnsAsync((string id) => userList.FirstOrDefault(u => u.Id == id));

            userManager.Setup(um => um
                .UpdateAsync(It.IsAny<User>()))
                .ReturnsAsync(IdentityResult.Success);

            return userManager;
        }
    }
}