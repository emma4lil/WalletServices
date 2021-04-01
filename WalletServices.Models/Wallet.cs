using System;
using System.Collections.Generic;

namespace WalletServices.Models
{
    /// <summary>
    /// Represents a wallet owned by a user
    /// </summary>
    public class Wallet : BaseEntity
    {
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public Boolean IsMainCurrency { get; set; }

        public User User { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}