using WebApp501.Core.Models.Cocktail;

namespace WebApp501.Web.Areas.Admin.Models
{
    public class MyCocktailsViewModel
    {
        public IEnumerable<CocktailServiceModel> AddedCocktails { get; set;} = new List<CocktailServiceModel>();
    }
}