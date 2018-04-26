using System.Collections.Generic;
using LinFx.CMS.Roles.Dto;
using LinFx.CMS.Users.Dto;

namespace LinFx.CMS.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
