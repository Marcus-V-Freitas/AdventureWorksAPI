using System;

namespace Domain.Entities
{
    public class CurrencyRate
    {
        public int? CurrencyRateID { get; private set; }
        public DateTime? CurrencyRateDate { get; private set; }
        public string FromCurrencyCode { get; private set; }
        public string ToCurrencyCode { get; private set; }
        public double? AverageRate { get; private set; }
        public double? EndOfDayRate { get; private set; }
    }
}