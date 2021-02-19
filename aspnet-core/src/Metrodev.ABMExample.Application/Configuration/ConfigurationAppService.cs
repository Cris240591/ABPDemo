using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Metrodev.ABMExample.Configuration.Dto;

namespace Metrodev.ABMExample.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABMExampleAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
