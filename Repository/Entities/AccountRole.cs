using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class AccountRole : AuditableEntity
    {
        public string AccountId { get; set; } = default!;
        public string RoleId { get; set; } = default!;


        public Account Account { get; set; } = default!;
        public Role Role { get; set; } = default!;
    }
}
