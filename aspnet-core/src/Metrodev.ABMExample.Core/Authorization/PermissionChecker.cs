using Abp.Authorization;
using Metrodev.ABMExample.Authorization.Roles;
using Metrodev.ABMExample.Authorization.Users;

namespace Metrodev.ABMExample.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
