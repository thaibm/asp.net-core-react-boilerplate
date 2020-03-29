using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ANC.React.Authorization.Roles;
using ANC.React.Authorization.Users;
using ANC.React.MultiTenancy;

namespace ANC.React.EntityFrameworkCore
{
    public class ReactDbContext : AbpZeroDbContext<Tenant, Role, User, ReactDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ReactDbContext(DbContextOptions<ReactDbContext> options)
            : base(options)
        {
        }
    }
}
