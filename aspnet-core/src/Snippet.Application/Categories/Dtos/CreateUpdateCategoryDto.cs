using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Categories.Dtos
{
    [AutoMapTo(typeof(Category))]
    public class CreateUpdateCategoryDto
    {
        //[ForeignKey(nameof(Category))]
        public string CategoryType { get; set; }
    }
}
