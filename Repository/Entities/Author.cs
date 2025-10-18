using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Author : AuditableEntity
    {
        public string AccountId { get; set; } = default!;
        public bool Restricted { get; set; }
        public string RankId { get; set; } = default!; // FK to AuthorRank
        public int VerifiedStatus { get; set; }
        public int TotalStory { get; set; }
        public int TotalFollower { get; set; }


        public Account Account { get; set; } = default!;
        public AuthorRank Rank { get; set; } = default!;
        public ICollection<Story> Stories { get; set; } = new List<Story>();
    }
}
