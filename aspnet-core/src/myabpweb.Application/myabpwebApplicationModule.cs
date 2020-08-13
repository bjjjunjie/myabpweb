using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using myabpweb.Authorization;

namespace myabpweb
{
    [DependsOn(
        typeof(myabpwebCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class myabpwebApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<myabpwebAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(myabpwebApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
