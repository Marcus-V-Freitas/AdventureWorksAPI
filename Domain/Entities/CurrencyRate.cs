using System;

namespace Domain.Entities
{
    public class CurrencyRate
    {
        public int CurrencyRateID { get; set; }
        public DateTime CurrencyRateDate { get; set; }
        public string FromCurrencyCode { get; set; }
        public string ToCurrencyCode { get; set; }
        public double AverageRate { get; set; }
        public double EndOfDayRate { get; set; }
    }
}