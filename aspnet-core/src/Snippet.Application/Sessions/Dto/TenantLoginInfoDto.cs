using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Snippet.MultiTenancy;

namespace Snippet.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
