using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LinFx.CMS.Configuration;
using LinFx.CMS.EntityFrameworkCore;
using LinFx.CMS.Migrator.DependencyInjection;

namespace LinFx.CMS.Migrator
{
    [DependsOn(typeof(CMSEntityFrameworkModule))]
    public class CMSMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public CMSMigratorModule(CMSEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;
            _appConfiguration = AppConfigurations.Get(typeof(CMSMigratorModule).GetAssembly().GetDirectoryPathOrNull());
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(CMSConsts.ConnectionStringName);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CMSMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
