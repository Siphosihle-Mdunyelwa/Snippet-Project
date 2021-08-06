using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Snippet.Categories;
using Snippet.Topics.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Topics
{
    public class TopicAppService : SnippetAppServiceBase, ITopicAppService
    {
        private readonly IRepository<Topic, Guid> _repositoryTopic;
        private readonly ITopicManager _topicManager;
        private readonly IRepository<Category, Guid> _categoryRepository;

        public TopicAppService(IRepository<Topic, Guid> repositoryTopic, ITopicManager topicManager, IRepository<Category, Guid> categoryRepository)
        {
            _repositoryTopic = repositoryTopic;
            _topicManager = topicManager;
            _categoryRepository = categoryRepository;
        }

        public async Task<CreateUpdateTopicDto> CreateAsync(CreateUpdateTopicDto input)
        {
            var user = AbpSession.UserId;
            /**
             * If the categoy does not exist 
             * Create one
             * User category id to get category (Selected category)
             * 
             */
            var category = await _categoryRepository.FirstOrDefaultAsync(input.Category.Id);
            if (category == null)
            {
              category  = await _categoryRepository.InsertAsync(ObjectMapper.Map<Category>(input.Category));
            }
            
            CurrentUnitOfWork.SaveChangesAsync();

            var topic = new Topic
            {
                Title = input.Title,
                Description = input.Description,
                CategoryId = category.Id,
                UserId = user
            };
            return ObjectMapper.Map<CreateUpdateTopicDto>(await _topicManager.CreateAsync(ObjectMapper.Map<Topic>(topic)));
        }

        public async Task DeleteAsync(Guid id)
        {
            await _topicManager.DeleteAsync(id);
        }

        public async Task<ListResultDto<ListTopicDto>> GetAllAsync()
        {
            var c = await _repositoryTopic.GetAllListAsync();
            return new ListResultDto<ListTopicDto>(ObjectMapper.Map<List<ListTopicDto>>(c));
        }

        public async Task<ListTopicDto> GetAsync(Guid id)
        {
            var topicFromDb = await _repositoryTopic.GetAsync(id);
            return ObjectMapper.Map<ListTopicDto>(topicFromDb);
        }

        public async Task<CreateUpdateTopicDto> UpdateAsync(TopicDto topic)
        {
            var topicFromDB = await _repositoryTopic.FirstOrDefaultAsync(topic.Id);

            if (topicFromDB == null)
            {
                throw new Exception("Error Here");
            }

            var id = topicFromDB.Id;
            ObjectMapper.Map(topic, topicFromDB);
            topicFromDB.Id = id;


            return ObjectMapper.Map<CreateUpdateTopicDto>(await _repositoryTopic.UpdateAsync(topicFromDB));

            //var mappedTop = ObjectMapper.Map<Topic>(topic);
            //return ObjectMapper.Map<CreateUpdateTopicDto>(await _topicManager.UpdateAsync(mappedTop));
        }
    }
}
