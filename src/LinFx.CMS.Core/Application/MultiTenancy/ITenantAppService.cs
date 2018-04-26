using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LinFx.CMS.MultiTenancy.Dto;

namespace LinFx.CMS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
