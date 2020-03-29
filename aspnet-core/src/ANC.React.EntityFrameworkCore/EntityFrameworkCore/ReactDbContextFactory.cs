using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ANC.React.Configuration;
using ANC.React.Web;

namespace ANC.React.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ReactDbContextFactory : IDesignTimeDbContextFactory<ReactDbContext>
    {
        public ReactDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ReactDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ReactDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ReactConsts.ConnectionStringName));

            return new ReactDbContext(builder.Options);
        }
    }
}
