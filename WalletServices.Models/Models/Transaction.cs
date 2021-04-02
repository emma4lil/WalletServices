using System;
using System.Collections.Generic;
using System.Text;

namespace WalletServices.Models
{
    public class Transaction : BaseEntity
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Amount { get; set; }
        public string TransactionType { get; set; }

        public Boolean Approved { get; set; }
        
        public Wallet Wallet { get; set; }
    }
}
