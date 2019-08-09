using Microsoft.EntityFrameworkCore;

namespace BizarreStatusServer.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> users) : base(users) { }

        public DbSet<User> Users { get; set; }
    }
}
