using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Snippet.Authorization.Roles;
using Snippet.Authorization.Users;
using Snippet.MultiTenancy;
using Snippet.Topics;
using Snippet.CodeSnippets;
using Snippet.Categories;

namespace Snippet.EntityFrameworkCore
{
    public class SnippetDbContext : AbpZeroDbContext<Tenant, Role, User, SnippetDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<CodeSnippet> Snippets { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        public SnippetDbContext(DbContextOptions<SnippetDbContext> options)
            : base(options)
        {
        }
    }
}
