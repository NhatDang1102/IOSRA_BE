using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class OperationMod : AuditableEntity
    {
        public string AccountId { get; set; } = default!;
        public DateTime? AssignedDate { get; set; }
        public int ReportsGenerated { get; set; }
        public Account Account { get; set; } = default!;
    }
}
