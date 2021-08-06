using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Categories
{
    public class CategoryManager : ICategoryManager
    {
        private readonly IRepository<Category, Guid> _categoryRepository;

        public CategoryManager(IRepository<Category, Guid> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Category> CreateAsync(Category category)
        {
            return await _categoryRepository.InsertAsync(category);
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            var categoryFromDB = await _categoryRepository.FirstOrDefaultAsync(category.Id);

            if (categoryFromDB == null)
            {
                throw new Exception("Error Here");
            }

            return await _categoryRepository.UpdateAsync(categoryFromDB);
        }

        public async Task<List<Category>> GetAllAsync()
        {
            var results = await _categoryRepository.GetAll()
                .ToListAsync();
            return results;
        }

        public async Task<Category> GetAsync(Guid id)
        {
            return await _categoryRepository.FirstOrDefaultAsync(id);
        }

        public async Task DeleteAsync(Guid id)
        {
            var catg = await _categoryRepository.FirstOrDefaultAsync(id);

            if (catg == null)
            {
                throw new Exception("Error Here");
            }

            await _categoryRepository.DeleteAsync(catg.Id);
        }
    }
}
