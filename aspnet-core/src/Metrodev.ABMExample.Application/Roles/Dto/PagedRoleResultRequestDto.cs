using Abp.Application.Services.Dto;

namespace Metrodev.ABMExample.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

