using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using myabpweb.Configuration.Dto;

namespace myabpweb.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : myabpwebAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
