using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApp501.Infrastructure
{
    public class WebApp501DbContext : IdentityDbContext
    {
        public WebApp501DbContext(DbContextOptions<WebApp501DbContext> options)
            : base(options)
        {
        }
    }
}