using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Categories.Dtos
{
    public class CategoryAppService : SnippetAppServiceBase, ICategoryAppService
    {
        private readonly IRepository<Category, Guid> _repositoryCategory;
        private readonly ICategoryManager _categoryManager;
        public CategoryAppService(IRepository<Category, Guid> repositoryCategory, ICategoryManager categoryManager)
        {
            _repositoryCategory = repositoryCategory;
            _categoryManager = categoryManager;
        }

        public async Task<CreateUpdateCategoryDto> CreateAsync(CreateUpdateCategoryDto category)
        {
            return ObjectMapper.Map<CreateUpdateCategoryDto>(await _categoryManager.CreateAsync(ObjectMapper.Map<Category>(category)));
        }

        public async Task DeleteAsync(Guid id)
        {
            await _categoryManager.DeleteAsync(id);
        }

        public async Task<ListResultDto<ListCategoryDto>> GetAllAsync()
        {
            var c = await _repositoryCategory.GetAllListAsync();
            return new ListResultDto<ListCategoryDto>(ObjectMapper.Map<List<ListCategoryDto>>(c));
        }

        public async Task<ListCategoryDto> GetAsync(Guid id)
        {
            var categoryFromDb = await _repositoryCategory.GetAsync(id);
            return ObjectMapper.Map<ListCategoryDto>(categoryFromDb);
        }

        public async Task<CreateUpdateCategoryDto> UpdateAsync(CategoryDto category)
        {
            var categoryFromDB = await _repositoryCategory.FirstOrDefaultAsync(category.Id);

            if (categoryFromDB == null)
            {
                throw new Exception("Error Here");
            }

            var id = categoryFromDB.Id;
            ObjectMapper.Map(category, categoryFromDB);
            categoryFromDB.Id = id;


            return ObjectMapper.Map<CreateUpdateCategoryDto>(await _repositoryCategory.UpdateAsync(categoryFromDB));

            //var mappedTop = ObjectMapper.Map<Category>(category);
            //return ObjectMapper.Map<CreateUpdateCategoryDto>(await _categoryManager.UpdateAsync(mappedTop));
        }
    }
}
