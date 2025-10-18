using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class ChapterComment : AuditableEntity
    {
        public string CommentId { get; set; } = Guid.NewGuid().ToString();
        public string ReaderId { get; set; } = default!; // account id
        public string ChapterId { get; set; } = default!;
        public string Content { get; set; } = default!;
        public int Status { get; set; }


        public Account Reader { get; set; } = default!;
        public Chapter Chapter { get; set; } = default!;
    }
}
