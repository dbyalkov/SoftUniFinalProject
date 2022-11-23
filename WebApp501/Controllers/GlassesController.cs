using Microsoft.AspNetCore.Mvc;

namespace WebApp501.Controllers
{
    public class GlassesController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}