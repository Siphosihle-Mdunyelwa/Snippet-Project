using Abp.Application.Services;
using Snippet.MultiTenancy.Dto;

namespace Snippet.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

