using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WalletServices.Models
{
    public class ValueType
    {
        private bool IsEqual(Money lm, Money rm)
        {
            if (lm.Currency == rm.Currency) return true;
            return false;
        }
    }
}
