using System.Threading.Tasks;
using ANC.React.Configuration.Dto;

namespace ANC.React.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
