using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Snippet.CodeSnippets;
using Snippet.CodeSnippets.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.CodeSnippets
{
    public interface ISnippetAppService : IApplicationService
    {
        Task<CreateSnippetInput> CreateAsync(CreateSnippetInput snippetDto);
        Task<ListResultDto<SnippetListDto>> GetAllAsync();
        Task<SnippetListDto> GetAsync(Guid id);
        Task<UpdateSnippetDto> UpdateAsync(SnippetDto snippetDto);
        Task DeleteAsync(Guid snippetId);
    }
}
