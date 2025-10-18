using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class OpRequest : AuditableEntity
    {
        public string RequestId { get; set; } = Guid.NewGuid().ToString();
        public string AuthorId { get; set; } = default!; // account id
        public int RequestType { get; set; } // upgrade / withdraw
        public string? RequestContent { get; set; }
        public long? WithdrawAmount { get; set; }
        public string? OmodId { get; set; } // ops mod id
        public int Status { get; set; }
        public string? WithdrawCode { get; set; }


        public Account Author { get; set; } = default!;
    }
}
