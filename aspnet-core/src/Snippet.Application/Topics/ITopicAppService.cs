using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Snippet.Topics.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Topics
{
    public interface ITopicAppService : IApplicationService
    {
        Task<CreateUpdateTopicDto> CreateAsync(CreateUpdateTopicDto topicDto);
        Task<ListTopicDto> GetAsync(Guid topicId);
        Task<ListResultDto<ListTopicDto>> GetAllAsync();
        Task<CreateUpdateTopicDto> UpdateAsync(TopicDto topicDto);
        Task DeleteAsync(Guid topicId);
    }
}
