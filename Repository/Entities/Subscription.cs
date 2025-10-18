using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Subscription : AuditableEntity
    {
        public string SubId { get; set; } = Guid.NewGuid().ToString();
        public string UserId { get; set; } = default!; // account id
        public string PlanCode { get; set; } = default!;
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public DateTime? LastClaimDate { get; set; }
        public int ClaimedToday { get; set; }


        public Account User { get; set; } = default!;
        public SubscriptionPlan Plan { get; set; } = default!;
    }
}
