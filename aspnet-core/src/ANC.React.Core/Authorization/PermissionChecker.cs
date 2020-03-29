using Abp.Authorization;
using ANC.React.Authorization.Roles;
using ANC.React.Authorization.Users;

namespace ANC.React.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
