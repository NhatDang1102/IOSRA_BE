using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class ChapterPurchaseLog : AuditableEntity
    {
        public string ChapterPurchaseId { get; set; } = Guid.NewGuid().ToString();
        public string ChapterId { get; set; } = default!;
        public string AccountId { get; set; } = default!;
        public long DiaPrice { get; set; }


        public Chapter Chapter { get; set; } = default!;
        public Account Account { get; set; } = default!;
    }
}
