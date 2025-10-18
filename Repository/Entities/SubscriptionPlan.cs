using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class SubscriptionPlan : AuditableEntity
    {
        public string PlanCode { get; set; } = default!; // PK (string)
        public string PlanName { get; set; } = default!;
        public long PriceCoin { get; set; }
        public int DailyClaimLimit { get; set; }
        public int DurationDays { get; set; }


        public ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();
    }
}
