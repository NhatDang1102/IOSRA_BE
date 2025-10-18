using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Account : AuditableEntity
    {
        public string AccountId { get; set; } = Guid.NewGuid().ToString();
        public string Username { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public int Status { get; set; }
        public int Strike { get; set; }
        public string? AvatarUrl { get; set; }


        public DiaWallet? Wallet { get; set; }
        public Reader? Reader { get; set; }
        public Author? Author { get; set; }
        public Admin? Admin { get; set; }
        public ContentMod? ContentMod { get; set; }
        public OperationMod? OperationMod { get; set; }


        public ICollection<AccountRole> AccountRoles { get; set; } = new List<AccountRole>();
        public ICollection<ChapterPurchaseLog> ChapterPurchases { get; set; } = new List<ChapterPurchaseLog>();
        public ICollection<Report> ReportsFiled { get; set; } = new List<Report>();
        public ICollection<ChapterComment> Comments { get; set; } = new List<ChapterComment>();
    }
}
