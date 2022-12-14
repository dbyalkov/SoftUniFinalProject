using Microsoft.AspNetCore.Identity;

using WebApp501.Core.Contracts;
using WebApp501.Core.Services;
using WebApp501.Infrastructure.Data.Entities;
using WebApp501.Tests.Common;

namespace WebApp501.Tests.UnitTests
{
    [TestFixture]
    public class AdminUserServiceUnitTest : UnitTestsBase
    {
        private new UserManager<User> userManager;
        private IUserService userService;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.userManager = base.userManager.Object;
            this.userService = new UserService(this.repo, this.userManager, this.mapper);
        }

        [Test]
        public async Task Forget_ShouldReturnTrue()
        {
            //Arrange
            string userId = "GuestUserId";

            //Act
            var usersBeforeForget = this.repo.AllReadonly<User>()
                .Where(u => !u.IsDeleted)
                .Count();

            var result = await this.userService.Forget(userId);

            await this.repo.SaveChangesAsync();

            //Assert
            Assert.IsTrue(result);

            //Assert
            var usersAfterForget = this.repo.AllReadonly<User>()
                .Where(u => !u.IsDeleted)
                .Count();
            Assert.That(usersAfterForget + 1, Is.EqualTo(usersBeforeForget));
        }
    }
}