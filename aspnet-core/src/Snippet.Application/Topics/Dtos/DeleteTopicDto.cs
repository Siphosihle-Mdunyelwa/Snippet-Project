using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Topics.Dtos
{
    public class DeleteTopicDto : EntityDto<Guid>
    {
        public string Description { get; set; }
        public string Title { get; set; }
    }
}
