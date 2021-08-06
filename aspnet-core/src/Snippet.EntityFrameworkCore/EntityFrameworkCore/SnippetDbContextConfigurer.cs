using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Snippet.EntityFrameworkCore
{
    public static class SnippetDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SnippetDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SnippetDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
