using System;

namespace Domain.Entities
{
    public class SpecialOffer
    {
        public int? SpecialOfferID { get; private set; }
        public string Description { get; private set; }
        public double? DiscountPct { get; private set; }
        public string Type { get; private set; }
        public string Category { get; private set; }
        public DateTime? StartDate { get; private set; }
        public DateTime? EndDate { get; private set; }
        public int? MinQty { get; private set; }
        public int? MaxQty { get; private set; }
    }
}