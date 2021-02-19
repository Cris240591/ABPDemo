using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Metrodev.ABMExample.Authorization.Roles;
using Metrodev.ABMExample.Authorization.Users;
using Metrodev.ABMExample.MultiTenancy;
using Metrodev.ABMExample.Products;

namespace Metrodev.ABMExample.EntityFrameworkCore
{
    public class ABMExampleDbContext : AbpZeroDbContext<Tenant, Role, User, ABMExampleDbContext>
    {
        public DbSet<Product> Products { get; set; }

        /* Define a DbSet for each entity of the application */
        
        public ABMExampleDbContext(DbContextOptions<ABMExampleDbContext> options)
            : base(options)
        {
        }
    }
}
