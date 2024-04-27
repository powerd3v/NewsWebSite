using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace NewsWebSite.Data
{
    public class NewsDbContext(DbContextOptions<NewsDbContext> options) : IdentityDbContext<IdentityUser>(options)
    {
    }
}
