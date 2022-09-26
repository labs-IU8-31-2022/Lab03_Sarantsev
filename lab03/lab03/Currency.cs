using System;
namespace lab03
{
    public class Currency
    {
        public double Value { get; set; }
        public Currency()
        {
            Value = 0; 
        }
        public Currency(double value_)
        {
            Value = value_;
        }

    }

    public class CurrencyUSD : Currency
    {
        public double ExchangeRate { get; set; }
        public double ValueUSD { get; set; }
        public CurrencyUSD(double value, double rate) : base(value)
        {
            ExchangeRate = rate;
        }
        public CurrencyUSD(double value_)
        {
            ValueUSD = value_;
        }
        public static implicit operator CurrencyRUB(CurrencyUSD tmp)
        {
            return new CurrencyRUB(tmp.Value * tmp.ExchangeRate);
        }
        public static implicit operator CurrencyEUR(CurrencyUSD tmp)
        {
            return new CurrencyEUR(tmp.Value / tmp.ExchangeRate);
        }

    }

    public class CurrencyEUR: Currency
    {
        public double ExchangeRate { get; set; }
        public double ValueEUR { get; set; }
        public CurrencyEUR(double value, double rate) : base(value)
        {
            ExchangeRate = rate;
        }
        public CurrencyEUR(double value_)
        {
            ValueEUR = value_;
        }
        public static implicit operator CurrencyRUB(CurrencyEUR tmp)
        {
            return new CurrencyRUB(tmp.Value * tmp.ExchangeRate);
        }
        public static implicit operator CurrencyUSD(CurrencyEUR tmp)
        {
            return new CurrencyUSD(tmp.Value * tmp.ExchangeRate);
        }
    }

    public class CurrencyRUB: Currency
    {
        public double ExchangeRate { get; set; }
        public double ValueRUB { get; set; }
        public CurrencyRUB(double value_)
        {
            ValueRUB = value_;
        }
        public CurrencyRUB(double value, double rate) : base(value)
        {
            ExchangeRate = rate;
        }
        public static implicit operator CurrencyUSD(CurrencyRUB tmp)
        {
            return new CurrencyUSD(tmp.Value / tmp.ExchangeRate);
        }
        public static implicit operator CurrencyEUR(CurrencyRUB tmp)
        {
            return new CurrencyEUR(tmp.Value / tmp.ExchangeRate);
        }

    }
}

