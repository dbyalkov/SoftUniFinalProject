using Microsoft.AspNetCore.Identity;

using WebApp501.Core.Contracts;
using WebApp501.Core.Services;
using WebApp501.Infrastructure.Data.Entities;
using WebApp501.Tests.Common;

namespace WebApp501.Tests.UnitTests
{
    [TestFixture]
    public class UserServiceUnitTests : UnitTestsBase
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
        public async Task All_ShouldReturnCorrectUsersAndBartenders()
        {
            //Arrange
            int bartenderId = 1;

            //Act
            var result = await this.userService.All();

            //Assert
            var usersCount = this.repo.AllReadonly<User>().Count();
            var resultUsers = result.ToList();
            Assert.That(usersCount, Is.EqualTo(resultUsers.Count()));

            //Assert
            var bartenderCounts = this.repo.AllReadonly<Bartender>().Count();
            var resultBartenders = resultUsers.Where(u => u.Age != 0);
            Assert.That(bartenderCounts, Is.EqualTo(resultBartenders.Count()));

            //Assert
            var bartender = await this.repo.GetByIdAsync<Bartender>(bartenderId);
            var bartenderUser = resultBartenders
                .FirstOrDefault(b => b.Email == bartender.User.Email);
            Assert.IsNotNull(bartenderUser);
            Assert.That(bartenderUser.Age, Is.EqualTo(bartender.Age));
        }

        [Test]
        public async Task UserName_ShouldReturnCorrectResult()
        {
            //Arrange
            string userId = "GuestUserId";

            //Act
            var result = await this.userService.UserNameAsync(userId);

            //Assert
            var guestUser = this.repo.AllReadonly<User>()
                .Where(u => u.Id == userId)
                .Where(u => !u.IsDeleted)
                .FirstOrDefault();

            string guestUserName = guestUser.UserName.Remove(9);

            Assert.That(guestUserName, Is.EqualTo(result));
        }
    }
}