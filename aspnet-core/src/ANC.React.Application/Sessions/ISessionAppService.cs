using System.Threading.Tasks;
using Abp.Application.Services;
using ANC.React.Sessions.Dto;

namespace ANC.React.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
