using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Snippet.Categories.Dtos;
using Snippet.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Topics.Dtos
{
    [AutoMapFrom(typeof(Topic))]
    public class TopicDto : EntityDto<Guid>
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public CreateUpdateCategoryDto Category { get; set; }
    }
}
