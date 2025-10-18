using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class WalletPayment : AuditableEntity
    {
        public string TrsId { get; set; } = Guid.NewGuid().ToString();
        public string WalletId { get; set; } = default!;
        public int Type { get; set; }
        public long CoinDelta { get; set; }
        public long CoinAfter { get; set; }
        public string? RefId { get; set; }


        public DiaWallet Wallet { get; set; } = default!;
    }
}
