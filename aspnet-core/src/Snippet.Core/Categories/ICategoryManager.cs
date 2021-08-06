using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Categories
{
    public interface ICategoryManager : IDomainService
    {
        Task<Category> CreateAsync(Category category);
        Task<Category> GetAsync(Guid categoryId);
        Task<List<Category>> GetAllAsync();
        Task<Category> UpdateAsync(Category category);
        Task DeleteAsync(Guid categoryId);
    }
}
