using System.Threading.Tasks;
using Abp.Application.Services;
using LinFx.CMS.Sessions.Dto;

namespace LinFx.CMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
