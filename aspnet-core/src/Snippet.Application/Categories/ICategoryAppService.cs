using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Categories.Dtos
{
    public interface ICategoryAppService : IApplicationService
    {
        Task<CreateUpdateCategoryDto> CreateAsync(CreateUpdateCategoryDto categoryDto);
        Task<ListCategoryDto> GetAsync(Guid categoryId);
        Task<ListResultDto<ListCategoryDto>> GetAllAsync();
        Task<CreateUpdateCategoryDto> UpdateAsync(CategoryDto categoryDto);
        Task DeleteAsync(Guid categoryId);
    }
}
