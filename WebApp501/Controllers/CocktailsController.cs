using Microsoft.AspNetCore.Mvc;

namespace WebApp501.Controllers
{
    public class CocktailsController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}