using System;
using System.Collections.Generic;
using System.Text;

namespace WalletServices.Models
{
    class Product : BaseEntity
    {
        public string Name { get; set; }
        public Money Price { get; set; } = new Money(value: 10, currency: "NGN");
        public string Description { get; set; }
    }
}
