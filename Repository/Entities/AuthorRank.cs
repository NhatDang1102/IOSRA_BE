using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class AuthorRank : AuditableEntity
    {
        public string RankId { get; set; } = Guid.NewGuid().ToString();
        public string RankName { get; set; } = default!;
        public decimal RewardRate { get; set; }
        public int MinFollowers { get; set; }
        public ICollection<Author> Authors { get; set; } = new List<Author>();
    }
}
