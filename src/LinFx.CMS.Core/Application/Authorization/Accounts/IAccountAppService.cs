using System.Threading.Tasks;
using Abp.Application.Services;
using LinFx.CMS.Authorization.Accounts.Dto;

namespace LinFx.CMS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
