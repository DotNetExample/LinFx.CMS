using Abp.Dapper;
using Abp.EntityFrameworkCore.Configuration;
using Abp.IdentityServer4;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using DapperExtensions.Sql;
using LinFx.CMS.EntityFrameworkCore.Seed;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Common;
using System.Reflection;

namespace LinFx.CMS.EntityFrameworkCore
{
    [DependsOn(
        typeof(CMSCoreModule),
        typeof(AbpDapperModule),
        typeof(AbpZeroCoreEntityFrameworkCoreModule),
        typeof(AbpZeroCoreIdentityServerEntityFrameworkCoreModule))]
    public class CMSEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<CMSDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                        CMSDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    else
                        CMSDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CMSEntityFrameworkModule).GetAssembly());
            DapperExtensions.DapperExtensions.SqlDialect = new MySqlDialect();
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new List<Assembly> { typeof(CMSCoreModule).GetAssembly() });
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }

    public static class CMSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CMSDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CMSDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
