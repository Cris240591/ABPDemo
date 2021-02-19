using Abp.AutoMapper;
using Metrodev.ABMExample.Authentication.External;

namespace Metrodev.ABMExample.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
