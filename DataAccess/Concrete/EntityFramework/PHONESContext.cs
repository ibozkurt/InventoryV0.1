using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class PHONESContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
    }
}
