using Abp.Domain.Services;
using Snippet.CodeSnippets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Snippets
{
    public interface ICodeSnippet : IDomainService
    {
        Task<CodeSnippet> CreateAsync(CodeSnippet snippet);
        Task<CodeSnippet> GetAsync(Guid snippetId);
        Task<List<CodeSnippet>> GetAllAsync();
        Task<CodeSnippet> UpdateAsync(CodeSnippet snippet);
        Task DeleteAsync(Guid snippetId);
        //Task<object> GetByIdAsync(Guid id);
    }
}
