using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Metrodev.ABMExample.Controllers
{
    public abstract class ABMExampleControllerBase: AbpController
    {
        protected ABMExampleControllerBase()
        {
            LocalizationSourceName = ABMExampleConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
