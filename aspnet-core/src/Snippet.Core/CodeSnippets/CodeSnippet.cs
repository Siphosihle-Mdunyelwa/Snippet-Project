using Abp.Domain.Entities.Auditing;
using Snippet.Authorization.Users;
using Snippet.Categories;
using Snippet.Topics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.CodeSnippets
{
    [Table("AppSnippets")]
    public class CodeSnippet : FullAuditedEntity<Guid>
    {
        [Required]
        public virtual string Description { get; set; }

        [Required]
        public virtual string Code { get; set; }

        [Required]
        public virtual string Language { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public long? UserId { get; set; }

        [ForeignKey("TopicId")]
        public Topic Topic { get; set; }
        public Guid? TopicId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public Guid? CategoryId { get; set; }

        public static CodeSnippet CreateAsync(Guid snippetId, string description, string code, string language)
        {
            var snippet = new CodeSnippet
            {
                Id = snippetId,
                Description = description,
                Code = code,
                Language = language
            };

            return snippet;
        }
    }
}
