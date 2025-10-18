using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Follow : AuditableEntity
    {
        public string FollowerId { get; set; } = default!; // account
        public string FolloweeId { get; set; } = default!; // author account
        public bool NotiNewStory { get; set; }
    }
}
