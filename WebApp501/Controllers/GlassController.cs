using Microsoft.AspNetCore.Mvc;

namespace WebApp501.Controllers
{
    public class GlassController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}