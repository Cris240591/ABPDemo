using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Metrodev.ABMExample.EntityFrameworkCore;
using Metrodev.ABMExample.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Metrodev.ABMExample.Web.Tests
{
    [DependsOn(
        typeof(ABMExampleWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ABMExampleWebTestModule : AbpModule
    {
        public ABMExampleWebTestModule(ABMExampleEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABMExampleWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ABMExampleWebMvcModule).Assembly);
        }
    }
}