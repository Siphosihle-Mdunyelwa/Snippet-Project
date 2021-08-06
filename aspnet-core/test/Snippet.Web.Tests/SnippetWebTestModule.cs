using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Snippet.EntityFrameworkCore;
using Snippet.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Snippet.Web.Tests
{
    [DependsOn(
        typeof(SnippetWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SnippetWebTestModule : AbpModule
    {
        public SnippetWebTestModule(SnippetEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SnippetWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SnippetWebMvcModule).Assembly);
        }
    }
}