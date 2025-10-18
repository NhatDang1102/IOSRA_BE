using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class ContentMod : AuditableEntity
    {
        public string AccountId { get; set; } = default!;
        public DateTime? AssignedDate { get; set; }
        public string? Phone { get; set; }
        public int TotalApprovedStories { get; set; }
        public int TotalRejectedStories { get; set; }
        public int TotalReportedHandled { get; set; }
        public Account Account { get; set; } = default!;
    }
}
