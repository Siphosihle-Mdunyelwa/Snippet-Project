using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Categories.Dtos
{
    public class DeleteCategoryDto : EntityDto<Guid>
    {
        public string CategoryType { get; set; }
    }
}
