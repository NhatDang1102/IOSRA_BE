using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class ChapterVoice : AuditableEntity
    {
        public string ChapterId { get; set; } = default!;
        public string VoiceId { get; set; } = default!;
        public string? CloudUrl { get; set; }


        public Chapter Chapter { get; set; } = default!;
        public Voice Voice { get; set; } = default!;
    }
}
