using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BizarreStatusServer.Models
{
    public class RoleContext : DbContext
    {
        public RoleContext(DbContextOptions<RoleContext> roles) : base(roles)
        {
        }

        public DbSet<Role> Roles { get; set; }
    }
}
