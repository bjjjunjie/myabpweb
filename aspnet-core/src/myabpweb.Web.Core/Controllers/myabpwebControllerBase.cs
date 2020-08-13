using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace myabpweb.Controllers
{
    public abstract class myabpwebControllerBase: AbpController
    {
        protected myabpwebControllerBase()
        {
            LocalizationSourceName = myabpwebConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
