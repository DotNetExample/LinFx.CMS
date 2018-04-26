using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LinFx.CMS.Authorization.Roles;
using LinFx.CMS.Authorization.Users;
using LinFx.CMS.MultiTenancy;
using Abp.IdentityServer4;

namespace LinFx.CMS.EntityFrameworkCore
{
    public class CMSDbContext : AbpZeroDbContext<Tenant, Role, User, CMSDbContext>, IAbpPersistedGrantDbContext
    {
        /* Define a DbSet for each entity of the application */
        
        public CMSDbContext(DbContextOptions<CMSDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConfigurePersistedGrantEntity();
        }

        public DbSet<PersistedGrantEntity> PersistedGrants { get; set; }
    }
}
