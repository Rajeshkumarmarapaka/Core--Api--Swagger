using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiSwag.Models
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options):base(options)
        {

        }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Values> Values { get; set; }
    }
}
