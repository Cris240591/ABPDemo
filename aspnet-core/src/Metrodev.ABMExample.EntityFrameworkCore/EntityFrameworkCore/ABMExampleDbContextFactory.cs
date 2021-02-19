using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Metrodev.ABMExample.Configuration;
using Metrodev.ABMExample.Web;

namespace Metrodev.ABMExample.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABMExampleDbContextFactory : IDesignTimeDbContextFactory<ABMExampleDbContext>
    {
        public ABMExampleDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABMExampleDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABMExampleDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABMExampleConsts.ConnectionStringName));

            return new ABMExampleDbContext(builder.Options);
        }
    }
}
