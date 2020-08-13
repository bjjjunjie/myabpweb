using System.Threading.Tasks;
using myabpweb.Configuration.Dto;

namespace myabpweb.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
