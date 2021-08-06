using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Snippet.Controllers
{
    public abstract class SnippetControllerBase: AbpController
    {
        protected SnippetControllerBase()
        {
            LocalizationSourceName = SnippetConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
