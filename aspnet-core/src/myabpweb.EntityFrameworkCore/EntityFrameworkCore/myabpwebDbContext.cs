using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using myabpweb.Authorization.Roles;
using myabpweb.Authorization.Users;
using myabpweb.MultiTenancy;

namespace myabpweb.EntityFrameworkCore
{
    public class myabpwebDbContext : AbpZeroDbContext<Tenant, Role, User, myabpwebDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public myabpwebDbContext(DbContextOptions<myabpwebDbContext> options)
            : base(options)
        {
        }
    }
}
