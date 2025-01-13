using HospitalManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagement.DAL.Configurations;

public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder.HasKey(d => d.Id);
        builder.Property(d => d.Name)
            .IsRequired()
            .HasMaxLength(64);
        builder.Property(d => d.Surname)
            .IsRequired()
            .HasMaxLength(64);
        builder.Property(d => d.ImageUrl)
            .HasMaxLength(255);
        builder.HasOne(d => d.Department)
            .WithMany(d => d.Doctors)
            .HasForeignKey(d => d.DepartmentId);
    }
}
