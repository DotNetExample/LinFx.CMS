using System.Threading.Tasks;
using LinFx.CMS.Configuration.Dto;

namespace LinFx.CMS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
