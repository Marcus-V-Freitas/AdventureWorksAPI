using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class EmployeeAddressConfiguration : IEntityTypeConfiguration<EmployeeAddress>
    {
        public void Configure(EntityTypeBuilder<EmployeeAddress> builder)
        {
            builder.ToTable("employeeaddress");

            builder.HasKey(x => new { x.AddressID, x.EmployeeID });

            builder.HasOne(x => x.Employee)
                .WithMany()
                .HasForeignKey(x => x.EmployeeID);

            builder.HasOne(x => x.Address)
                .WithMany()
                .HasForeignKey(x => x.AddressID);
        }
    }
}