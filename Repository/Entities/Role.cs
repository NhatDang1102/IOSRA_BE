using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Role : AuditableEntity
    {
        public string RoleId { get; set; } = Guid.NewGuid().ToString();
        public string RoleCode { get; set; } = default!;
        public string RoleName { get; set; } = default!;
        public ICollection<AccountRole> AccountRoles { get; set; } = new List<AccountRole>();
    }
}
