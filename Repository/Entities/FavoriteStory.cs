using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class FavoriteStory : AuditableEntity
    {
        public string ReaderId { get; set; } = default!;
        public string StoryId { get; set; } = default!;
        public bool NotiNewChapter { get; set; }


        public Reader Reader { get; set; } = default!;
        public Story Story { get; set; } = default!;
    }
}
