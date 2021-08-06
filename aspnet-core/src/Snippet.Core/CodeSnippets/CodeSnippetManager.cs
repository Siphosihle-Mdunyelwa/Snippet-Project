using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Snippet.CodeSnippets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Snippets
{
    public class CodeSnippetManager : ICodeSnippet
    {
        private readonly IRepository<CodeSnippet, Guid> _repositorySnippet;

        public CodeSnippetManager(IRepository<CodeSnippet, Guid> repositorySnippet)
        {
            _repositorySnippet = repositorySnippet;
        }

        public async Task<CodeSnippet> CreateAsync(CodeSnippet input)
        {
            return await _repositorySnippet.InsertAsync(input);
        }

        public async Task DeleteAsync(Guid id)
        {
            var dlt = await _repositorySnippet.FirstOrDefaultAsync(id);

            if (dlt == null)
            {
                throw new Exception("Could not delete");
            }

            await _repositorySnippet.DeleteAsync(dlt.Id);
        }

        public async Task<List<CodeSnippet>> GetAllAsync()
        {
            var results = await _repositorySnippet.GetAll()
                .Include(s => s.User)
                .Include(s => s.Category)
                .Include(s => s.Topic)
                .ToListAsync();
            return results;
        }

        public async Task<CodeSnippet> GetAsync(Guid id)
        {
            return await _repositorySnippet.FirstOrDefaultAsync(id);
        }

        //public async Task<object> GetByIdAsync(Guid id)
        //{
        //    return await _repositorySnippet.FirstOrDefaultAsync(id);
        //}

        public async Task<CodeSnippet> UpdateAsync(CodeSnippet snippet)
        {
            var snippetFromDB= await _repositorySnippet.FirstOrDefaultAsync(snippet.Id);

            if (snippetFromDB == null)
            {
                throw new Exception("Could not updated");
            }

            return await _repositorySnippet.UpdateAsync(snippetFromDB);
        }
    }
}
