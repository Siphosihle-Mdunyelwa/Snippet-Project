﻿using Abp.Application.Services.Dto;
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
    public class CreateSnippetInput
    {
        public virtual string Description { get; set; }
        public virtual string Code { get; set; }
        public CategoryDto Category { get; set; }
        public TopicDto Topic { get; set; }
    }
}
