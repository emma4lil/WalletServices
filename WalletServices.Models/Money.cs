using System;

namespace WalletServices.Models
{
    public struct Money
    {
        private Decimal _value;
        public string Currency;

        public Money(decimal value, String currency)
        {
            _value = value;
            Currency = currency;
        }

        private static bool IsSameCurrency(Money money, Money currency2)
        {
            if (money.Currency == currency2.Currency) return true;
            return false;
        }

        public static Money operator +(Money lparam, Money rparam)
        {
            if (IsSameCurrency(lparam, rparam))
                return new Money()
                { Currency = lparam.Currency, _value = lparam._value + rparam._value };
            throw new DifferentCurrencyException();
        }

        public static Money operator -(Money lparam, Money rparam)
        {
            if (IsSameCurrency(lparam, rparam))
                return new Money()
                { Currency = lparam.Currency, _value = lparam._value - rparam._value };
            throw new DifferentCurrencyException();
        }
    }

    public class DifferentCurrencyException : Exception
    {
    }
}