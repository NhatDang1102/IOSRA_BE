using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Voice : AuditableEntity
    {
        public string VoiceId { get; set; } = Guid.NewGuid().ToString();
        public string VoiceName { get; set; } = default!;
        public ICollection<ChapterVoice> ChapterVoices { get; set; } = new List<ChapterVoice>();
    }
}
