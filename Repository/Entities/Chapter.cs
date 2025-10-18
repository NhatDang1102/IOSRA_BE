using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Chapter : AuditableEntity
    {
        public string ChapterId { get; set; } = Guid.NewGuid().ToString();
        public string StoryId { get; set; } = default!;
        public int ChapterNo { get; set; }
        public long DiasPrice { get; set; }
        public int AccessType { get; set; } // 0 free, 1 paid
        public int Status { get; set; }


        public Story Story { get; set; } = default!;
        public ICollection<ChapterPurchaseLog> Purchases { get; set; } = new List<ChapterPurchaseLog>();
        public ICollection<ChapterLocalization> Localizations { get; set; } = new List<ChapterLocalization>();
        public ICollection<ChapterVoice> Voices { get; set; } = new List<ChapterVoice>();
        public ICollection<ChapterComment> Comments { get; set; } = new List<ChapterComment>();
    }
}
