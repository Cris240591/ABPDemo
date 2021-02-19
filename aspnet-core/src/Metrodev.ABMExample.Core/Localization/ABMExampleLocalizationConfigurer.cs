using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Metrodev.ABMExample.Localization
{
    public static class ABMExampleLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ABMExampleConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ABMExampleLocalizationConfigurer).GetAssembly(),
                        "Metrodev.ABMExample.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
