using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Metrodev.ABMExample.Authorization;

namespace Metrodev.ABMExample
{
    [DependsOn(
        typeof(ABMExampleCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABMExampleApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABMExampleAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABMExampleApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
