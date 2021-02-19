using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Metrodev.ABMExample.EntityFrameworkCore
{
    public static class ABMExampleDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABMExampleDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABMExampleDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
