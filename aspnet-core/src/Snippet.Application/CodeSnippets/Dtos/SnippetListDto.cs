using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Snippet.CodeSnippets;
using Snippet.Topics.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.CodeSnippets.Dtos
{
    [AutoMapFrom(typeof(CodeSnippet))]
    public class SnippetListDto
    {
        public string Description { get; set; }
        public string Code { get; set; }
        public TopicDto Topic { get; set;}
    }
}
