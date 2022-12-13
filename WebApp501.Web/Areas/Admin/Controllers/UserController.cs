using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

using WebApp501.Core.Constants;
using WebApp501.Core.Contracts;
using WebApp501.Core.Models.User;

using static WebApp501.Infrastructure.Data.AdminConstants;

namespace WebApp501.Web.Areas.Admin.Controllers
{
    public class UserController : AdminController
    {
        private readonly IUserService users;
        private readonly IMemoryCache cache;

        public UserController(
            IUserService _users,
            IMemoryCache _cache)
        {
            this.users = _users;
            this.cache = _cache;
        }

        [Route("User/All")]
        public async Task<IActionResult> All()
        {
            var appUsers = this.cache.Get<IEnumerable<UserServiceModel>>(UsersCacheKey);

            if (appUsers == null)
            {
                appUsers = await this.users.All();

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(5));

                this.cache.Set(UsersCacheKey, appUsers, cacheOptions);
            }

            return View(appUsers);
        }

        [HttpPost]
        public async Task<IActionResult> Forget(string userId)
        {
            bool result = await this.users.Forget(userId);

            if (result)
            {
                TempData["message"] = "User is now forgotten!";
            }
            else
            {
                TempData["message"] = "User is unforgetable!";
            }

            return RedirectToAction(nameof(All));
        }
    }
}