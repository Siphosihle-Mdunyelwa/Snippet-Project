using System.Threading.Tasks;
using Snippet.Configuration.Dto;

namespace Snippet.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
