using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class ProductSubCategoryConfiguration : IEntityTypeConfiguration<ProductSubCategory>
    {
        public void Configure(EntityTypeBuilder<ProductSubCategory> builder)
        {
            builder.ToTable("productsubcategory");

            builder.HasKey(x => x.ProductSubcategoryID);

            builder.HasOne(x => x.ProductCategory)
                .WithMany()
                .HasForeignKey(x => x.ProductCategoryID);
        }
    }
}