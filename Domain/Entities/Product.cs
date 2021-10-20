using System;

namespace Domain.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public int MakeFlag { get; set; }
        public int FinishedGoodsFlag { get; set; }
        public string Color { get; set; }
        public double StandardCost { get; set; }
        public double ListPrice { get; set; }
        public string Size { get; set; }
        public string SizeUnitMeasureCode { get; set; }
        public string WeightUnitMeasureCode { get; set; }
        public double Weight { get; set; }
        public int DaysToManufacture { get; set; }
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public int ProductSubcategoryID { get; set; }
        public int ProductModelID { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime SellEndDate { get; set; }
        public DateTime DiscontinuedDate { get; set; }

        public virtual ProductSubCategory ProductSubCategory { get; set; }
        public virtual ProductModel ProductModel { get; set; }
    }
}