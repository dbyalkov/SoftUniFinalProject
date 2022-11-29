using Microsoft.AspNetCore.Mvc;

namespace WebApp501.Controllers
{
    public class BartenderController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Become()
        {
            return View();
        }
    }
}