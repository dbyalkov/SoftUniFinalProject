using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;

using static WebApp501.Infrastructure.Data.AdminConstants;

namespace WebApp501.Web.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdminRoleName)]
    public class AdminController : Controller
    {

    }
}