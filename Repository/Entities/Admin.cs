using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{


    public class Admin : AuditableEntity
    {
        public string AccountId { get; set; } = default!;
        public string? Department { get; set; }
        public string? Notes { get; set; }
        public Account Account { get; set; } = default!;
    }
}
