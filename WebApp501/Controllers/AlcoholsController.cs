using Microsoft.AspNetCore.Mvc;

namespace WebApp501.Controllers
{
    public class AlcoholsController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}