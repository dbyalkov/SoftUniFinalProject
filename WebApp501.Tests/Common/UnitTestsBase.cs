using AutoMapper;

using EasyRank.Tests.Common.Mocks;

using Microsoft.AspNetCore.Identity;

using Moq;

using WebApp501.Infrastructure.Data;
using WebApp501.Infrastructure.Data.Common;
using WebApp501.Infrastructure.Data.Entities;
using WebApp501.Tests.Common.Mocks;

namespace WebApp501.Tests.Common
{
    public class UnitTestsBase
    {
        protected WebApp501TestDb testDb;
        private WebAppDbContext dbContext;
        protected IMapper mapper;
        protected IRepository repo;
        protected Mock<UserManager<User>> userManager;

        [OneTimeSetUp]
        public void SetUpBase()
        {
            this.dbContext = DatabaseMock.Instance;
            this.testDb = new WebApp501TestDb(dbContext);
            this.mapper = MapperMock.Instance;
            this.repo = new RepoMock(dbContext);
            this.userManager = UserManagerMock.MockUserManager(new List<User>
            {
                this.testDb.GuestUser
            });
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            dbContext.Dispose();
        }
    }
}