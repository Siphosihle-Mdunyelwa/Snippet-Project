using Abp.AutoMapper;
using Snippet.CodeSnippets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Categories.Dtos
{
    [AutoMapFrom(typeof(Category))]
    public class ListCategoryDto
    {
        public string CategoryType { get; set; }
    }
}
