using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace blog.Models
{
    public class AppUserDbContext : IdentityDbContext<AppUser>
    {
        public AppUserDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static AppUserDbContext Create()
        {
            return new AppUserDbContext();
        }
    }
}
