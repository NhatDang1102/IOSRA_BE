using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class DiaPayment : AuditableEntity
    {
        public string TopupId { get; set; } = Guid.NewGuid().ToString();
        public string WalletId { get; set; } = default!;
        public string Provider { get; set; } = default!;
        public long AmountVnd { get; set; }
        public long DiamondGranted { get; set; }
        public int Status { get; set; }


        public DiaWallet Wallet { get; set; } = default!;
    }
}
