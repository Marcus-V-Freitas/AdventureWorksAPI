using System;

namespace Domain.Entities
{
    public class SpecialOffer
    {
        public int SpecialOfferID { get; set; }
        public string Description { get; set; }
        public double DiscountPct { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MinQty { get; set; }
        public int MaxQty { get; set; }
    }
}