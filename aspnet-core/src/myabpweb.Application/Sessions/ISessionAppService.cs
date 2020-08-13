using System.Threading.Tasks;
using Abp.Application.Services;
using myabpweb.Sessions.Dto;

namespace myabpweb.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
