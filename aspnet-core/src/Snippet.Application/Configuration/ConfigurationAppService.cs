using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Snippet.Configuration.Dto;

namespace Snippet.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SnippetAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
