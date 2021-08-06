using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Snippet.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Topics
{
    public class TopicManager : ITopicManager
    {
        private readonly IRepository<Topic, Guid> _repositoryTopic;
        private readonly IRepository<Category, Guid> _categoryRepository;

        public TopicManager(IRepository<Topic, Guid> repositoryTopic)
        {
            _repositoryTopic = repositoryTopic;
        }

        public async Task<Topic> CreateAsync(Topic input)
        {
            return await _repositoryTopic.InsertAsync(input);
        }

        public async Task DeleteAsync(Guid id)
        {
            var top = await _repositoryTopic.FirstOrDefaultAsync(id);

            if (top == null)
            {
                throw new Exception("Error Here");
            }

            await _repositoryTopic.DeleteAsync(top.Id);
        }

        public async Task<List<Topic>> GetAllAsync()
        {
            var results = await _repositoryTopic.GetAll()
                .ToListAsync();
            return results;
        }

        public async Task<Topic> GetAsync(Guid id)
        {
            return await _repositoryTopic.FirstOrDefaultAsync(id);
        }

        public async Task<Topic> UpdateAsync(Topic topic)
        {
            var topicFromDB = await _repositoryTopic.FirstOrDefaultAsync(topic.Id);

            if (topicFromDB == null)
            {
                throw new Exception("Error Here");
            }

            return await _repositoryTopic.UpdateAsync(topicFromDB);
        }
    }
}
