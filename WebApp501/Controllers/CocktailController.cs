using Microsoft.AspNetCore.Mvc;

namespace WebApp501.Controllers
{
    public class CocktailController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}