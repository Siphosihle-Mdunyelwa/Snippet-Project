using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Topics
{
    public interface ITopicManager : IDomainService
    {
        Task<Topic> CreateAsync(Topic topic);
        Task<Topic> GetAsync(Guid topicId);
        Task<List<Topic>> GetAllAsync();
        Task<Topic> UpdateAsync(Topic topic);
        Task DeleteAsync(Guid topicId);
    }
}
