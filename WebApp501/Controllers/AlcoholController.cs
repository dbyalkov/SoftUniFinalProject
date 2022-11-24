using Microsoft.AspNetCore.Mvc;

namespace WebApp501.Controllers
{
    public class AlcoholController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}