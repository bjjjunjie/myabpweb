using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using myabpweb.Configuration;
using myabpweb.Web;

namespace myabpweb.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class myabpwebDbContextFactory : IDesignTimeDbContextFactory<myabpwebDbContext>
    {
        public myabpwebDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<myabpwebDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            myabpwebDbContextConfigurer.Configure(builder, configuration.GetConnectionString(myabpwebConsts.ConnectionStringName));

            return new myabpwebDbContext(builder.Options);
        }
    }
}
