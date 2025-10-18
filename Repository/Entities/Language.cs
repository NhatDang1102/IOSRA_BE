using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Language : AuditableEntity
    {
        public string LangId { get; set; } = "vi"; // e.g., vi, en
        public string LangName { get; set; } = default!;
        public ICollection<ChapterLocalization> Localizations { get; set; } = new List<ChapterLocalization>();
    }
}
