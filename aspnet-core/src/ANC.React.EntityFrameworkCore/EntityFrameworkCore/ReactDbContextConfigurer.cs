using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ANC.React.EntityFrameworkCore
{
    public static class ReactDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ReactDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ReactDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
