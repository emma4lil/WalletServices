using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WalletServices.Models
{
    public class User :  IdentityUser
    {
        public string FirstName { get; set; }
        public ICollection<Wallet> Wallets { get; set; }
    }
}
