using System;
using System.Collections.Generic;
using System.Text;

namespace WalletServices.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public ICollection<Wallet> Wallets { get; set; }
    }
}
