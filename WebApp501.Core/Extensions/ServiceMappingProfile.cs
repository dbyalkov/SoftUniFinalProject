using AutoMapper;

using WebApp501.Core.Models.Bartender;
using WebApp501.Core.Models.Cocktail;
using WebApp501.Core.Models.User;
using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Core.Extensions
{
    public class ServiceMappingProfile : Profile
    {
        public ServiceMappingProfile()
        {
            this.CreateMap<Cocktail, CocktailServiceModel>()
                .ForMember(cs => cs.ImageUrl, config => config.MapFrom(c => c.Image.ImageUrl));

            this.CreateMap<Cocktail, CocktailDetailsServiceModel>()
                .ForMember(cs => cs.Alcohol, config => config.MapFrom(c => c.Alcohol.Name))
                .ForMember(cs => cs.Glass, config => config.MapFrom(c => c.Glass.Name));

            this.CreateMap<Bartender, BartenderServiceModel>()
                .ForMember(bs => bs.Email, config => config.MapFrom(b => b.User.Email));

            this.CreateMap<Cocktail, CocktailIndexServiceModel>()
                .ForMember(cs => cs.ImageUrl, config => config.MapFrom(c => c.Image.ImageUrl));

            this.CreateMap<TypeOfAlcohol, CocktailAlcoholServiceModel>();
            this.CreateMap<Glass, CocktailGlassServiceModel>();

            this.CreateMap<Bartender, UserServiceModel>()
                .ForMember(us => us.Email, config => config.MapFrom(b => b.User.Email))
                .ForMember(us => us.FullName, config => config.MapFrom(b => $"{b.FirstName} {b.User.MiddleName.Trim()} {b.LastName}"));

            this.CreateMap<User, UserServiceModel>()
                .ForMember(us => us.UserId, config => config.MapFrom(u => u.Id))
                .ForMember(us => us.FullName, config => config.MapFrom(u => u.MiddleName))
                .ForMember(us => us.Age, config => config.MapFrom(u => 0));
        }
    }
}