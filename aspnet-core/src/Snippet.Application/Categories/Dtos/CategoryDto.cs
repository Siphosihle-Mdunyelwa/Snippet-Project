using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Categories.Dtos
{
    [AutoMapFrom(typeof(Category))]
    public class CategoryDto : EntityDto<Guid>
    {
        public string Category_Type { get; set; }
        
    }
}
