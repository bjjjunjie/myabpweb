using Abp.Application.Services;
using myabpweb.MultiTenancy.Dto;

namespace myabpweb.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

