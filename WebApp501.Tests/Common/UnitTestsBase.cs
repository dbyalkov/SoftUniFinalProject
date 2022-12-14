using AutoMapper;

using EasyRank.Tests.Common.Mocks;

using WebApp501.Infrastructure.Data;
using WebApp501.Infrastructure.Data.Common;
using WebApp501.Tests.Common.Mocks;

namespace WebApp501.Tests.Common
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
            dbContext = DatabaseMock.Instance;
            testDb = new WebApp501TestDb(dbContext);
            mapper = MapperMock.Instance;
            repo = new RepoMock(dbContext);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            dbContext.Dispose();
        }
    }
}