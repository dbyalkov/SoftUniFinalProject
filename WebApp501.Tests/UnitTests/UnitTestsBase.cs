using AutoMapper;

using EasyRank.Tests.Common.Mocks;

using WebApp501.Infrastructure.Data;
using WebApp501.Infrastructure.Data.Common;
using WebApp501.Tests.Common;
using WebApp501.Tests.Common.Mocks;

namespace WebApp501.Tests.UnitTests
{
    public class UnitTestsBase
    {
        protected WebApp501TestDb testDb;
        private WebAppDbContext dbContext;
        protected IMapper mapper;
        protected IRepository repo;

        [OneTimeSetUp]
        public void SetUpBase()
        {
            this.dbContext = DatabaseMock.Instance;
            this.testDb = new WebApp501TestDb(this.dbContext);
            this.mapper = MapperMock.Instance;
            this.repo = new RepoMock(this.dbContext);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            this.dbContext.Dispose();
        }
    }
}