using System.Collections.Generic;
using LinFx.CMS.Roles.Dto;

namespace LinFx.CMS.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
