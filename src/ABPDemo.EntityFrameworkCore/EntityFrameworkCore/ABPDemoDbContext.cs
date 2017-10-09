using Abp.Zero.EntityFrameworkCore;
using ABPDemo.Authorization.Roles;
using ABPDemo.Authorization.Users;
using ABPDemo.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace ABPDemo.EntityFrameworkCore
{
    public class ABPDemoDbContext : AbpZeroDbContext<Tenant, Role, User, ABPDemoDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public ABPDemoDbContext(DbContextOptions<ABPDemoDbContext> options)
            : base(options)
        {

        }
    }
}
