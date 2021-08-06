using Abp.AutoMapper;
using Snippet.CodeSnippets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Categories.Dtos
{
    [AutoMapTo(typeof(Category))]
    public class ListCategoryDto
    {
        public string Category_Type { get; set; }
    }
}
