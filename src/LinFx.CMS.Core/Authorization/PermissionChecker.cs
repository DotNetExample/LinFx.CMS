using Abp.Authorization;
using LinFx.CMS.Authorization.Roles;
using LinFx.CMS.Authorization.Users;

namespace LinFx.CMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
