﻿using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Snippet.Categories;
using Snippet.CodeSnippets;
using Snippet.CodeSnippets.Dtos;
using Snippet.Snippets;
using Snippet.Topics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.CodeSnippets
{
    public class SnippetAppService : SnippetAppServiceBase, ISnippetAppService
    {
        private readonly IRepository<CodeSnippet, Guid> _repositorySnippet;
        private readonly ICodeSnippet _snippetManager;
        private readonly IRepository<Topic, Guid> _topicRepository;
        private readonly IRepository<Category, Guid> _categoryRepository;

        public SnippetAppService(IRepository<CodeSnippet, Guid> repositorySnippet, ICodeSnippet snippetManager, IRepository<Topic, Guid> topicRepository,
            IRepository<Category, Guid> categoryRepository)
        {
            _repositorySnippet = repositorySnippet;
            _snippetManager = snippetManager;
            _topicRepository = topicRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<CreateSnippetInput> CreateAsync(CreateSnippetInput input)
        {
            var user = AbpSession.UserId;
            var topic = await _topicRepository
                .GetAll()
                .Include(x => x.Category)
                .FirstOrDefaultAsync();
            var category = await _categoryRepository.FirstOrDefaultAsync(input.Category.Id);

            CurrentUnitOfWork.SaveChangesAsync();

            if (topic == null || category == null)
            {
                throw new Exception("No Topic and category was found");
            }
            var codeSnip = new CodeSnippet
            {
                Description = input.Description,
                Code = input.Code,
                TopicId = topic.Id,
                CategoryId = category.Id,
                UserId = user
            };
            return ObjectMapper.Map<CreateSnippetInput>(await _snippetManager.CreateAsync(ObjectMapper.Map<CodeSnippet>(codeSnip)));
        }

        public async Task<ListResultDto<SnippetListDto>> GetAllAsync()
        {
            var snippets = await _repositorySnippet
                .GetAll()
                .Include(x => x.Topic)
                .ThenInclude(c => c.Category)
                .ToListAsync();
            return new ListResultDto<SnippetListDto>(ObjectMapper.Map<List<SnippetListDto>>(snippets));
        }

        public async Task<SnippetListDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<SnippetListDto>(await _snippetManager.GetAsync(id));
        }

        public async Task DeleteAsync(Guid id)
        {
            await _snippetManager.DeleteAsync(id);
        }

        public async Task<UpdateSnippetDto> UpdateAsync(SnippetDto snippet)
        {
            var snippetFromDB = await _repositorySnippet.FirstOrDefaultAsync(snippet.Id);

            if (snippetFromDB == null)
            {
                throw new Exception("Error message here");
            }

            var id = snippetFromDB.Id;

            var mappedResult = ObjectMapper.Map(snippet, snippetFromDB);

            mappedResult.Id = id;

            return ObjectMapper.Map<UpdateSnippetDto>(await _snippetManager.UpdateAsync(mappedResult));
        }
    }
}

