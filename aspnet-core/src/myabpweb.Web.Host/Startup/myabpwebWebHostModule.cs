using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using myabpweb.Configuration;

namespace myabpweb.Web.Host.Startup
{
    [DependsOn(
       typeof(myabpwebWebCoreModule))]
    public class myabpwebWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public myabpwebWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(myabpwebWebHostModule).GetAssembly());
        }
    }
}
