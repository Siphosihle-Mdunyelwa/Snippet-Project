using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.CodeSnippets.Dtos
{
    public class UpdateSnippetDto : EntityDto<Guid>
    {
        public virtual string Description { get; set; }
        public virtual string Code { get; set; }
        public virtual string Language { get; set; }
    }
}
