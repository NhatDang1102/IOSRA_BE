using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class StoryTag : AuditableEntity
    {
        public string StoryId { get; set; } = default!;
        public string TagId { get; set; } = default!;


        public Story Story { get; set; } = default!;
        public Tag Tag { get; set; } = default!;
    }
}
