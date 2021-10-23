using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("employee");

            builder.HasKey(x => x.EmployeeID);

            builder.HasOne(x => x.Contact)
                   .WithMany()
                   .HasForeignKey(x => x.ContactID);
        }
    }
}