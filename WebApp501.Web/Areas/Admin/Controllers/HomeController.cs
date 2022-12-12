using Microsoft.AspNetCore.Mvc;

namespace WebApp501.Web.Areas.Admin.Controllers
{
    public class HomeController : AdminController
    {
        public IActionResult Index()
            => View();
    }
}