using System.Threading.Tasks;
using Abp.Application.Services;
using Snippet.Sessions.Dto;

namespace Snippet.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
