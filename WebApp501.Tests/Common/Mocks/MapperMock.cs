using AutoMapper;

using WebApp501.Core.Extensions;

namespace WebApp501.Tests.Common.Mocks
{
    public static class MapperMock
    {
        public static IMapper Instance
        {
            get
            {
                var mapperConfiguration = new MapperConfiguration(config =>
                {
                    config.AddProfile<ServiceMappingProfile>();
                });

                return new Mapper(mapperConfiguration);
            }
        }
    }
}