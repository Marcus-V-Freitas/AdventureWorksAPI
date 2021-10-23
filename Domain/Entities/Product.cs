using System;

namespace Domain.Entities
{
    public class Product
    {
        public int ProductID { get; private set; }
        public string Name { get; private set; }
        public string ProductNumber { get; private set; }
        public bool MakeFlag { get; private set; }
        public bool FinishedGoodsFlag { get; private set; }
        public string Color { get; private set; }
        public double? StandardCost { get; private set; }
        public double? ListPrice { get; private set; }
        public string Size { get; private set; }
        public string SizeUnitMeasureCode { get; private set; }
        public string WeightUnitMeasureCode { get; private set; }
        public double? Weight { get; private set; }
        public int? DaysToManufacture { get; private set; }
        public string ProductLine { get; private set; }
        public string Class { get; private set; }
        public string Style { get; private set; }
        public int? ProductSubcategoryID { get; private set; }
        public int? ProductModelID { get; private set; }
        public DateTime? SellStartDate { get; private set; }
        public DateTime? SellEndDate { get; private set; }
        public DateTime? DiscontinuedDate { get; private set; }

        public virtual ProductSubCategory ProductSubCategory { get; private set; }
        public virtual ProductModel ProductModel { get; private set; }
    }
}