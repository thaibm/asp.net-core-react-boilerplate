using Abp.Application.Services;
using ANC.React.MultiTenancy.Dto;

namespace ANC.React.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

