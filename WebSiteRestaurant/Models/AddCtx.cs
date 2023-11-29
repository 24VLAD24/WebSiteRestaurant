using WebSiteRestaurant.Models.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebSiteRestaurant.Models
{
    public class AppCtx : IdentityDbContext<User>
    {
        public AppCtx(DbContextOptions<AppCtx> options): base(options)
        {
            Database.EnsureCreated();
        } 

        public DbSet<Category> Categories { get; set; }
    }
}