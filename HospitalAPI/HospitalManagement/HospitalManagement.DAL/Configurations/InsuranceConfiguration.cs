using HospitalManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagement.DAL.Configurations;

public class InsuranceConfiguration : IEntityTypeConfiguration<Insurance>
{
    public void Configure(EntityTypeBuilder<Insurance> builder)
    {
        builder
            .HasKey(i => i.Id);
        builder.Property(i => i.PersonInsurance)
            .IsRequired()
            .HasMaxLength(64);
        builder.Property(i => i.Discount)
            .IsRequired()
            .HasMaxLength(128);
    }
}
