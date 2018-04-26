using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LinFx.CMS.Configuration;
using LinFx.CMS.Web;

namespace LinFx.CMS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CMSDbContextFactory : IDesignTimeDbContextFactory<CMSDbContext>
    {
        public CMSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CMSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CMSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CMSConsts.ConnectionStringName));

            return new CMSDbContext(builder.Options);
        }
    }
}
