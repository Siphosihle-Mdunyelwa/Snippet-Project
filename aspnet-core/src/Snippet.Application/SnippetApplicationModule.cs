using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Snippet.Authorization;
using Snippet.Authorization.Users;
using Snippet.Categories;
using Snippet.Categories.Dtos;
using Snippet.CodeSnippets;
using Snippet.CodeSnippets.Dtos;
using Snippet.Topics;
using Snippet.Topics.Dtos;
using Snippet.Users.Dto;

namespace Snippet
{
    [DependsOn(
        typeof(SnippetCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SnippetApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SnippetAuthorizationProvider>();
            Configuration.Modules.AbpAutoMapper().Configurators.Add(configuration =>
            {
                configuration.CreateMap<User, UserDto>();
                configuration.CreateMap<UserDto, User>();

                // Topic Mapping
                configuration.CreateMap<Topic, TopicDto>();
                configuration.CreateMap<TopicDto, Topic>();

                configuration.CreateMap<Topic, ListTopicDto>();
                configuration.CreateMap<ListTopicDto, Topic>();

                configuration.CreateMap<Topic, DeleteTopicDto>();
                configuration.CreateMap<DeleteTopicDto, Topic>();

                configuration.CreateMap<CreateUpdateTopicDto, Topic>();
                configuration.CreateMap<Topic, CreateUpdateTopicDto>();

                // Category Mapping
                configuration.CreateMap<Category, CategoryDto>();
                configuration.CreateMap<CategoryDto, Category>();

                configuration.CreateMap<Category, CreateUpdateCategoryDto>();
                configuration.CreateMap<CreateUpdateCategoryDto, Category>();

                configuration.CreateMap<Category, DeleteCategoryDto>();
                configuration.CreateMap<DeleteCategoryDto, Category>();

                configuration.CreateMap<Category, ListCategoryDto>();
                configuration.CreateMap<ListCategoryDto, Category>();

                // Snippets Mapping
                configuration.CreateMap<CodeSnippet, CreateSnippetInput>();
                configuration.CreateMap<CreateSnippetInput, CodeSnippet>();

                configuration.CreateMap<CodeSnippet, SnippetDetailDto>();
                configuration.CreateMap<SnippetDetailDto, CodeSnippet>();

                configuration.CreateMap<CodeSnippet, SnippetDeleteDto>();
                configuration.CreateMap<SnippetDeleteDto, CodeSnippet>();

                configuration.CreateMap<CodeSnippet, SnippetListDto>();
                configuration.CreateMap<SnippetListDto, CodeSnippet>();

                configuration.CreateMap<CodeSnippet, UpdateSnippetDto>();
                configuration.CreateMap<UpdateSnippetDto, CodeSnippet>();

                configuration.CreateMap<CodeSnippet, CategoryDetailDto>();
                configuration.CreateMap<CategoryDetailDto, CodeSnippet>();

                configuration.CreateMap<CodeSnippet, TopicDetailDto>();
                configuration.CreateMap<TopicDetailDto, CodeSnippet>();

                configuration.CreateMap<CodeSnippet, SnippetDto>();
                configuration.CreateMap<SnippetDto, CodeSnippet>();
            });
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SnippetApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
