using Abp.AutoMapper;
using Snippet.Categories.Dtos;
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
    public class SnippetDetailDto
    {
        // Snippet Properties
        public string Description { get; set; }
        public  string Code { get; set; }
        public  string Language { get; set; }

        public CreateUpdateCategoryDto Category { get; set; }
        public CreateUpdateTopicDto Topic { get; set; }

        // Topic Properties
        public List<TopicDetailDto> Topics { get; set; }

        // Category Properties
        public List<CategoryDetailDto> Categories { get; set; }
    }
}
