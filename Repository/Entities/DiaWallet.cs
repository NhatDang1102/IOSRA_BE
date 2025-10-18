using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class DiaWallet : AuditableEntity
    {
        public string WalletId { get; set; } = Guid.NewGuid().ToString();
        public string AccountId { get; set; } = default!;
        public long BalanceCoin { get; set; }
        public long LockedCoin { get; set; }


        public Account Account { get; set; } = default!;
        public ICollection<WalletPayment> WalletPayments { get; set; } = new List<WalletPayment>();
        public ICollection<DiaPayment> DiaPayments { get; set; } = new List<DiaPayment>();
    }
}
