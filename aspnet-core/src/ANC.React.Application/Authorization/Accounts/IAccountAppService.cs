using System.Threading.Tasks;
using Abp.Application.Services;
using ANC.React.Authorization.Accounts.Dto;

namespace ANC.React.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
