using Abp.Domain.Entities.Auditing;
using Snippet.Authorization.Users;
using Snippet.Categories;
using Snippet.CodeSnippets;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Topics
{
    [Table("AppTopics")]
    public class Topic : FullAuditedEntity<Guid>
    {
        [Required]
        public string Description { get; set; }
        
        public string Title { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public long? UserId { get; set; }

        public ICollection<CodeSnippet> CodeSnippets { get; set; }
    }
}
