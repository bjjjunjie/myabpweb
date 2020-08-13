using Abp.Authorization;
using myabpweb.Authorization.Roles;
using myabpweb.Authorization.Users;

namespace myabpweb.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
