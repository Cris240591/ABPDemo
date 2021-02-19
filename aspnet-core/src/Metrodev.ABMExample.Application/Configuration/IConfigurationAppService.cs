using System.Threading.Tasks;
using Metrodev.ABMExample.Configuration.Dto;

namespace Metrodev.ABMExample.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
