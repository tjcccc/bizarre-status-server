using Microsoft.EntityFrameworkCore;

namespace BizarreStatusServer.Models
{
    public class RoleContext : DbContext
    {
        public RoleContext(DbContextOptions<RoleContext> roles) : base(roles) { }

        public DbSet<Role> Roles { get; set; }
    }
}
