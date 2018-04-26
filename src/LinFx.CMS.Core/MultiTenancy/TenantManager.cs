using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using LinFx.CMS.Authorization.Users;
using LinFx.CMS.Editions;

namespace LinFx.CMS.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
