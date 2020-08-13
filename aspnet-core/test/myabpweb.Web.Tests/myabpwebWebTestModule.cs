using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using myabpweb.EntityFrameworkCore;
using myabpweb.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace myabpweb.Web.Tests
{
    [DependsOn(
        typeof(myabpwebWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class myabpwebWebTestModule : AbpModule
    {
        public myabpwebWebTestModule(myabpwebEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(myabpwebWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(myabpwebWebMvcModule).Assembly);
        }
    }
}