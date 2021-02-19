using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Metrodev.ABMExample.Configuration;

namespace Metrodev.ABMExample.Web.Host.Startup
{
    [DependsOn(
       typeof(ABMExampleWebCoreModule))]
    public class ABMExampleWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABMExampleWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABMExampleWebHostModule).GetAssembly());
        }
    }
}
