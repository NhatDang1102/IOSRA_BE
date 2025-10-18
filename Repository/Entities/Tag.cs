using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Tag : AuditableEntity
    {
        public string TagId { get; set; } = Guid.NewGuid().ToString();
        public string TagName { get; set; } = default!;
        public ICollection<StoryTag> StoryTags { get; set; } = new List<StoryTag>();
    }
}
