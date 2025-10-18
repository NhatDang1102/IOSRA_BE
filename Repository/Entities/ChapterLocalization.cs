using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class ChapterLocalization : AuditableEntity
    {
        public string ChapterId { get; set; } = default!;
        public string LangId { get; set; } = default!;
        public string? Content { get; set; }
        public int WordCount { get; set; }
        public string? CloudUrl { get; set; }


        public Chapter Chapter { get; set; } = default!;
        public Language Language { get; set; } = default!;
    }
}
