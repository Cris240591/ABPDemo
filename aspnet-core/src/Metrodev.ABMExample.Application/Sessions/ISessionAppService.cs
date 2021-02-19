using System.Threading.Tasks;
using Abp.Application.Services;
using Metrodev.ABMExample.Sessions.Dto;

namespace Metrodev.ABMExample.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
