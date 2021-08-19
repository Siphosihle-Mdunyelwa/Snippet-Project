using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet.Categories
{
    [Table("AppCategory")]
    public class Category : FullAuditedEntity<Guid>
    {
        [Required]
        public string CategoryType { get; set; }
    }
}
