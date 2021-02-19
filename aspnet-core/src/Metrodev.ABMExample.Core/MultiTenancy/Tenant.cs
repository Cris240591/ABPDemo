using Abp.MultiTenancy;
using Metrodev.ABMExample.Authorization.Users;

namespace Metrodev.ABMExample.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
