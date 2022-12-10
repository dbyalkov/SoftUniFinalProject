using WebApp501.Core.Contracts;
using WebApp501.Core.Services;
using WebApp501.Infrastructure.Data.Common;

namespace WebApp501.Extensions
{
    public static class WebApp501ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<ICocktailService, CocktailService>();
            services.AddScoped<IBartenderService, BartenderService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}