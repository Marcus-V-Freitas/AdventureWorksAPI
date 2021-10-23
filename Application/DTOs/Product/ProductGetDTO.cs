using Application.DTOs.ProductModel;
using Application.DTOs.ProductSubCategory;
using System;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Product
{
    public class ProductGetDTO
    {
        public int ProductID { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(25)]
        public string ProductNumber { get; set; }

        public bool MakeFlag { get; set; }

        public bool FinishedGoodsFlag { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(15)]
        public string Color { get; set; }

        [DataType(DataType.Currency)]
        public double? StandardCost { get; set; }

        [DataType(DataType.Currency)]
        public double? ListPrice { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public string Size { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(3)]
        public string SizeUnitMeasureCode { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(3)]
        public string WeightUnitMeasureCode { get; set; }

        [Range(1, int.MaxValue)]
        public double? Weight { get; set; }

        [Range(1, int.MaxValue)]
        public int? DaysToManufacture { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        public string ProductLine { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        public string Class { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        public string Style { get; set; }

        [Required]
        public int? ProductSubcategoryID { get; set; }

        [Required]
        public int? ProductModelID { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? SellStartDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? SellEndDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DiscontinuedDate { get; set; }

        public virtual ProductSubCategoryGetDTO ProductSubCategory { get; set; }
        public virtual ProductModelGetDTO ProductModel { get; set; }
    }
}