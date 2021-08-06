using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Topics.Dtos
{
    [AutoMapFrom(typeof(Topic))]
    public class ListTopicDto
    {
        public string Description { get; set; }
        public string Title { get; set; }
    }
}
