using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.CodeSnippets.Dtos
{
    [AutoMapFrom(typeof(CodeSnippet))]
    public class SnippetDto : EntityDto<Guid>
    {
        public string Description { get; set; }
        public string Code { get; set; }
        public string Language { get; set; }
    }
}
