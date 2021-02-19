using System.Threading.Tasks;
using Abp.Application.Services;
using Metrodev.ABMExample.Authorization.Accounts.Dto;

namespace Metrodev.ABMExample.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
