using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LinFx.CMS.Roles.Dto;
using LinFx.CMS.Users.Dto;

namespace LinFx.CMS.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
