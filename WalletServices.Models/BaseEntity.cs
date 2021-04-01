using System;
using System.Collections.Generic;
using System.Text;

namespace WalletServices.Models
{
    public class BaseEntity
    {
        public string Id { get; set; } 
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; }
    }
}
