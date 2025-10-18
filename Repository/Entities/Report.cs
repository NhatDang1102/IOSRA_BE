using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Report : AuditableEntity
    {
        public string ReportId { get; set; } = Guid.NewGuid().ToString();
        public int TargetType { get; set; } // story/chapter/comment/user
        public string TargetId { get; set; } = default!;
        public string ReporterId { get; set; } = default!;
        public string Reason { get; set; } = default!;
        public string? Details { get; set; }
        public int Status { get; set; }
        public string? ModeratorId { get; set; }
        public DateTime? ReviewedAt { get; set; }


        public Account Reporter { get; set; } = default!;
        public Account? Moderator { get; set; }
    }
}
