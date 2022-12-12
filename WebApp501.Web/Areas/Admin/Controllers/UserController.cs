using Microsoft.AspNetCore.Mvc;

using WebApp501.Core.Contracts;

namespace WebApp501.Web.Areas.Admin.Controllers
{
    public class UserController : AdminController
    {
        private readonly IUserService users;

        public UserController(IUserService _users)
        {
            this.users = _users;
        }

        [Route("User/All")]
        public async Task<IActionResult> All()
        {
            var appUsers = await this.users.All();

            return View(appUsers);
        }
    }
}