using System.Collections.Generic;
using System.Linq;
using LinFx.CMS.Roles.Dto;
using LinFx.CMS.Users.Dto;

namespace LinFx.CMS.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
