using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Snippet.Configuration;
using Snippet.Web;

namespace Snippet.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SnippetDbContextFactory : IDesignTimeDbContextFactory<SnippetDbContext>
    {
        public SnippetDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SnippetDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SnippetDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SnippetConsts.ConnectionStringName));

            return new SnippetDbContext(builder.Options);
        }
    }
}
