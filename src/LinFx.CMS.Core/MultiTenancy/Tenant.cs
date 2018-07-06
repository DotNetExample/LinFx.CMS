using Abp.MultiTenancy;
using LinFx.CMS.Authorization.Users;

namespace LinFx.CMS.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }

        /// <summary>
        /// 租户类型
        /// </summary>
        public int TenancyType { get; set; }
    }
}
