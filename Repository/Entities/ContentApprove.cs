using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class ContentApprove : AuditableEntity
    {
        public string ReviewId { get; set; } = Guid.NewGuid().ToString();
        public int ApproveType { get; set; } // story_new / chapter_new
        public string? StoryId { get; set; }
        public string? ChapterId { get; set; }
        public string? Source { get; set; }
        public double AiScore { get; set; }
        public int Status { get; set; } // pending/approved/rejected
        public string? ModeratorId { get; set; }


        public Story? Story { get; set; }
        public Chapter? Chapter { get; set; }
        public Account? Moderator { get; set; }
    }
}
