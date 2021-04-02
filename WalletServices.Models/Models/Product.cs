using System;
using System.Collections.Generic;
using System.Text;

namespace WalletServices.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; } 
        public string Currency { get; set; }
        public string Description { get; set; }
    }
}
