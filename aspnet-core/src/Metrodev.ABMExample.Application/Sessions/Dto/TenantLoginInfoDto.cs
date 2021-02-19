using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Metrodev.ABMExample.MultiTenancy;

namespace Metrodev.ABMExample.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
