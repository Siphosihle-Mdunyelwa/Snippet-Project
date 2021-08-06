using System.Threading.Tasks;
using Abp.Application.Services;
using Snippet.Authorization.Accounts.Dto;

namespace Snippet.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
