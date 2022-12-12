using AutoMapper;

using WebApp501.Core.Models.Cocktail;
using WebApp501.Web.Models.Cocktail;

namespace WebApp501.Web.Extensions
{
    public class ControllerMappingProfile : Profile
    {
        public ControllerMappingProfile()
        {
            this.CreateMap<CocktailDetailsServiceModel, CocktailFormModel>()
                .ForMember(cf => cf.Image, config => config.MapFrom(cs => cs.ImageUrl));
            this.CreateMap<CocktailDetailsServiceModel, CocktailDetailsViewModel>();
        }
    }
}