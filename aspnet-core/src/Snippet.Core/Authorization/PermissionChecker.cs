using Abp.Authorization;
using Snippet.Authorization.Roles;
using Snippet.Authorization.Users;

namespace Snippet.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
