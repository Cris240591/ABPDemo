using Abp.Application.Services;
using Metrodev.ABMExample.MultiTenancy.Dto;

namespace Metrodev.ABMExample.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

