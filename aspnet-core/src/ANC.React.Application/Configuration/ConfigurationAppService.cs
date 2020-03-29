using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ANC.React.Configuration.Dto;

namespace ANC.React.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ReactAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
